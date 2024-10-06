-- このluaスクリプトは、PT6_01_05_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:…教師が特定の生徒と食事なんかしていいのか？<br><ruby=ひいき>贔屓</ruby>ととられるかもしれないぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_05_0010006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:教師と生徒としてではなく<br>同じ騎士としてこの席に着いたつもりだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT6_01_05_0010007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:…へえ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_05_0010008")

-- ▼直接出力
wait_time(0.5)
CloseTalkWindow()
setup_small_camera_start(RndCamera007)
change_face(Actor002,"Sad")
wait_time(1.8)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
wait_time(1.5)
setup_small_camera_start()
change_face(Actor002,"Normal")
-- ▲直接出力

	--★★ランスロット★★:お前が学園に来て１ヶ月になるが<br>ここでの生活にはもう慣れたか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT6_01_05_0010009")


	--★★ノワール★★:…どうだろうな<br>慣れたかもしれないし、慣れてないかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_05_0010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:ディナタンはどうだ？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT6_01_05_0010011")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:気になるなら、俺じゃなくて<br>ディナタンに直接聞けばいいだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_05_0010012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:ディナタンは、相手を心配させまいと<br>平気なフリをする癖があるからな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT6_01_05_0010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT6_01_05_0010014","PT6_01_05_0010015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンなら大丈夫だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_05_0010017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺と一緒に傭兵をやってたくらいだ<br>あの頃に比べて随分強くなってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_05_0010018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:そうか<br>それならいいんだが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT6_01_05_0010019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:覚えてるんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_05_0010021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:覚えているさ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT6_01_05_0010022")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:あれはディナタンが３歳くらいのときだったか？<br>みんなで出かける前に突然高熱を出して…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT6_01_05_0010023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:元気だと言い張ったときだな<br>ベッドに連れていくのに苦労した
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_05_0010024")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:お前も変わらないな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT6_01_05_0010026")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…なにが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_05_0010027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:食べ物の好き嫌いがだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT6_01_05_0010028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:よ、余計なお世話だ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_05_0010029")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
