-- このluaスクリプトは、PT6_01C_09_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
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
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:…チッ。なんでアタシがアンタなんかと<br>ふたりきりでメシ食わなきゃいけねぇんだよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT6_01C_09_0010005")

	change_face(Actor001,"Sad")

	--★★ノワール★★:仕方ないだろ。ディナタンがブレイズ先生に<br>呼ばれて行っちゃったんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_09_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マルディサント★★:わーかってるよ！ンなことは！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT6_01C_09_0010007")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はそんなにイヤじゃないけどな<br>マルディサントと話す機会なんてそうそうないし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_09_0010008")

-- ▼直接出力
PlayPartVoice("マルディサント", "悩む")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★マルディサント★★:アタシも別に…<br>ふたりでいても話すことないってくらいで…
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT6_01C_09_0010009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:じゃあ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_09_0010010")

	open_select_window_tag(Actor001,"Normal","PT6_01C_09_0010011","PT6_01C_09_0010012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:はい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_09_0010014")

-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:あ？なんだよ、この手
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT6_01C_09_0010015")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:仲良くやろうっていう意味の握手
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_09_0010016")

-- ▼直接出力
PlayPartVoice("マルディサント", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★マルディサント★★:ハァ！？なんでアンタと<br>握手しなきゃなんねぇんだよ！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT6_01C_09_0010017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Shy")

	--★★マルディサント★★:いきなり距離詰めてくんな！<br>ダンドリ考えろ、ダンドリ！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT6_01C_09_0010018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:このプリン<br>マルディサントにあげるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_09_0010020")

-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:は？なんで？それはオニーサンのランチに<br>ついてるデザートだろ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT6_01C_09_0010021")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:お近づきのしるしにさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_09_0010022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルディサント★★:へえ、気が利くじゃん<br>せっかくだし、もらっといてやるよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT6_01C_09_0010023")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:ただ食ってるだけもなんだし<br>オニーサンから話題振ってくれよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT6_01C_09_0010025")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そういわれても…特にないなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_09_0010026")

-- ▼直接出力
PlayPartVoice("マルディサント", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:ハァ！？アタシと話す機会なんてそうそうないし<br>ってさっき言ってたろ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT6_01C_09_0010027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:機会はなかったけど<br>話題も別にないというか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_09_0010028")

-- ▼直接出力
PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:なんだよ、メンドクセー！！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT6_01C_09_0010029")

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
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
