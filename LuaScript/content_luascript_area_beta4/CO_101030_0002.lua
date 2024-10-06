-- このluaスクリプトは、CO_101030_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114031_01","114031_01_h")
Include("content_adv_advsmall_114031_01","Template114031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-120,CharaPos114031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_004)
	Camera002 = SetTemplate("Actor002",110,CharaPos114031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_003)
	InitializeTemplateRandomCamera114031_01()
	InitializeTemplate114031_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002, 0)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001,{0.331,-0.381,4.3})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{-0.72,-0.381,4})
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★エレイン★★:普段なら故郷に帰ってくると気持ちが安らぐんですけど
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010008")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0025")
-- ▲直接出力

	--★★エレイン★★:今日は先輩と一緒のせいかなんだかちょっぴり緊張しちゃいます…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:なにか恥ずかしい思い出でもあったりするのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:恥ずかしいというか…村の人たちには小さい頃の姿をたくさん見られていますから
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010011")


	--★★エレイン★★:お兄ちゃんと一緒に村中を走り回ってたこととか…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010012")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Shy")

	--★★エレイン★★:泣きべそをかいてお兄ちゃんに慰めてもらったこととか…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:昔から兄妹仲が良かったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010014")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:はい！先輩とディナタンみたいに！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010015")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010016")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:それにしても…ログレスと比べちゃうとここって、やっぱり田舎ですよね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010017")


	--★★エレイン★★:先輩も、そう思いませんか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010018")

	open_select_window_tag(Actor001,"Normal","CO_101030_00010019","CO_101030_00010020","CO_101030_00010021")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まぁ、確かに<br>そう思わなくもないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010023")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:そ、そうですよねっ！先輩の目から見ても、やっぱり…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010024")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺も田舎生まれの田舎育ちだからさこういう場所のほうが馴染みがあるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010025")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:なんていうか…この村にいるとすごく落ち着くしばらくのんびりしていきたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010026")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:…ほ、本当ですか？気に入っていただけて、嬉しいです！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010027")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:えへへ…それじゃあ、私のとっておきの<br>のんびりスポット、ご紹介しますね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010028")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はそうは思わないけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010031")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:え…そうですか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ。確かに都会ってわけじゃないけど<br>人通りも多いし、店もたくさんある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010033")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:街の人たちも皆、あたたかいしさ<br>いい村だと思うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010034")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:エレインが<br>優しい女の子に育ったのも納得だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010035")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Surprise")

	--★★エレイン★★:！！！？？？
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","CO_101030_00010036")

	close_cutin()
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:せ、先輩って…本当にすごいですね…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ん？なにが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010038")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Surprise")

	--★★エレイン★★:な、なんでもないです！無自覚なのが、いいんですから！！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010039")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなことないよ俺の故郷のほうが田舎だと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010042")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:故郷といえる場所はふたつあるけどどっちも、ここよりもっとなんにもないし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010043")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:そ、そこ張り合います！？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010044")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？<br>いや、張り合ってるつもりはないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010045")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ただ…本当の田舎はこんなもんじゃないぞ<br>っていう気持ちが湧き上がってきたというか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_00010046")

-- ▼直接出力
PlayPartVoice("エレイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:やっぱり張り合ってるじゃないですか！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010047")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:ふふ…先輩ったら、面白いですね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_00010048")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"エレイン")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
