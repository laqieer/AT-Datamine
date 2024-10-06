-- このluaスクリプトは、PT6_01B_12_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
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
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:寝てなくて大丈夫なのか？<br>あまり無理しないほうがいいぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01B_12_0010005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:俺のことなら心配無用！<br>このとおり、もうすっかり元気だ！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT6_01B_12_0010006")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★アーサー★★:その証拠にハラが減って仕方がない<br>眠ろうとしてもハラの音に起こされてしまう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT6_01B_12_0010007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:だから食う！<br>止めても無駄だぞ、ノワール！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT6_01B_12_0010008")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:止めるつもりなんてないよ<br>好きなだけ食べたらいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01B_12_0010009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:では、いただきまー…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT6_01B_12_0010010")

-- ▼直接出力
PlayActionDirect(Actor002,"to Sit01_Loop")
PlayPartVoice("アーサー", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★アーサー★★:ぐっ…！？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT6_01B_12_0010011")

	open_select_window_tag(Actor001,"Normal","PT6_01B_12_0010012","PT6_01B_12_0010013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:大丈夫か、アーサー！？<br>待ってろ、誰か呼んでくる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01B_12_0010015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:大丈夫<br>俺なら大丈夫だ、ノワール
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT6_01B_12_0010016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:お前を元気づけるつもりだったんだが…<br>逆に心配させてしまったか。面目ない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT6_01B_12_0010017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:だから言ったじゃないか<br>無理するからだぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01B_12_0010019")

-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:…すまんな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT6_01B_12_0010020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★アーサー★★:どうにもお前には<br>格好悪いところばかり見せてしまう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT6_01B_12_0010021")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:ノワールの言った通り<br>少々無理をしてしまったかもしれん
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT6_01B_12_0010023")

	change_face(Actor002,"Normal")

	--★★アーサー★★:だが、銀卓騎士団との決戦を控え<br>今、学園は大変な時期だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT6_01B_12_0010024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:俺だけが寝ているわけにはいかんよ<br>無理くらいさせてくれ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT6_01B_12_0010025")

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
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
