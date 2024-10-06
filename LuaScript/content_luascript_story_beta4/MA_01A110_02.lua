-- このluaスクリプトは、MA_01A110_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_03","111013_03_h")
Include("content_adv_advsmall_111013_03","Template111013_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111013_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111013_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111013_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_003)
	InitializeTemplateRandomCamera111013_03()
	InitializeTemplate111013_03()
-- ▼直接出力
PlayActionDirect(Actor003,"to Kneeling")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Kneeling")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101045","001","101045001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:そなたの胃の中が見たいのだ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020002")

	PlayAction(Actor005,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★グリートーネア★★:ルーシャス様…<br>ネアは恥ずかしい
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01A110_020003")


	--★★ルーシャス★★:喰らったものは何処にいく？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★グリートーネア★★:初めてです<br>そんな問いをなさる御方は
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01A110_020005")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力

	--★★ルーシャス★★:そなたに関心を抱くのは<br>いけないことか？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020007")

	PlayAction(Actor005,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "照れ")
-- ▲直接出力

	--★★グリートーネア★★:いいえ、いいえ、いいえルーシャス様<br>この初めての気持ちに戸惑っているだけです
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01A110_020009")


	--★★グリートーネア★★:このグリートーネア、ご用命あらば<br>円卓の騎士など瞬く間にやっつけて──
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01A110_020010")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "納得")
-- ▲直接出力

	--★★ルーシャス★★:期待して良いのだな？<br>グリートーネア
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020011")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "笑い")
-- ▲直接出力

	--★★グリートーネア★★:はい、はい、はいっ<br>ご期待くださいルーシャス様っ
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01A110_020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力

	--★★ルーシャス★★:先ほどの答えも聞きたいな、グリートーネア？<br>バルバロイが喰らった記憶は何処へ行くか
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020013")

-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:消化されるのでは
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A110_020015")

	PlayAction(Actor005,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "気合い")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★グリートーネア★★:クチを挟まないでっっ！！
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01A110_020017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "納得")
-- ▲直接出力

	--★★ヴェルナルス★★:…失礼
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A110_020018")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:そなたらが狂おしいほどに求め<br>喰らう『他者の存在』とその記憶──
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020019")


	--★★ルーシャス★★:まさか単に消化して終わり…などと<br>味気ないことはするまい？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020020")

-- ▼直接出力
 --PlayPartVoice("ローラ", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ローラ★★:──このような場に<br>お呼びいただいて恐縮ですが…
	Talk(Actor003,"CHRNAME_LOLA","speech","L","MA_01A110_020022")

-- ▼直接出力
 --PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:席を外しても…いい？
	Talk(Actor004,"CHRNAME_FREN","speech","L","MA_01A110_020024")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力

	--★★ルーシャス★★:真に恐ろしきはやはりＧＳよな、フレン<br>その点ではログレスに水を開けられている
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力

	--★★ルーシャス★★:このまま敗色が濃くなり続ければ<br>魔女は我らを喰らうだろう
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020027")


	--★★フレン★★:…だから？
	Talk(Actor004,"CHRNAME_FREN","speech","L","MA_01A110_020028")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:バルバロイに?み込まれれば跡形もあるまい<br>余らが行く末を知っておいたほうが良いだろう？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★グリートーネア★★:自らのお立場をわきまえていらっしゃる…<br>そう、お姉様らの牙はルーシャス様の首元…
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01A110_020030")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★グリートーネア★★:そして役立たずの小鳥は<br>一番にネアが喰ってあげます
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01A110_020031")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,-105,0.3)
wait_time(0.3)
PlayActionDirect(Actor003,"to  Std_Surp")
change_face(Actor003,"Sad")
wait_time(1.0)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "挨拶")
-- ▲直接出力

	--★★ルーシャス★★:ゆえに余が魔女へとかしづこう
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020033")


	--★★ルーシャス★★:人間の負の記憶を育み、至高の味を提供──<br>喰っても喰い足らぬほど究極の餌場を用意しよう
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020034")

-- ▼直接出力
 --PlayPartVoice("フレン", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★フレン★★:…ルーシャスくん
	Talk(Actor004,"CHRNAME_FREN","speech","L","MA_01A110_020035")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ルーシャス★★:そなたの妹は、気の毒であった…<br>これはその失策への罪滅ぼしでもある
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★グリートーネア★★:グリートンのことなど、良いのです…
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01A110_020038")

-- ▼直接出力
PlayAction(Actor003,"to Std_Loop")
 --PlayPartVoice("ルーシャス", "悲しみ")
-- ▲直接出力

	--★★ルーシャス★★:嗚呼、グリートン<br>許してくれ、グリートン
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020040")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★グリートーネア★★:ルーシャス、さま………<br>我らのような者のために涙してくださって…！
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01A110_020041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ルーシャス★★:余の心意気、受け取ってくれるか？<br>グリートーネア
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020042")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★グリートーネア★★:しかと。ルーシャス様っ
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01A110_020043")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "納得")
-- ▲直接出力

	--★★ルーシャス★★:ギネヴィアも見てくれるだろうか、将軍
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020044")

	change_face(Actor002,"Surprise")

	--★★ヴェルナルス★★:…？<br>なぜ、その名が今？
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A110_020045")

-- ▼直接出力
 --PlayPartVoice("グリートーネア", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★グリートーネア★★:ギネ、ヴィア──？
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01A110_020046")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:ああ、いけない。口が滑ったよ将軍<br>こう離れるとついつい思い出してしまってね
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "肯定3")
-- ▲直接出力

	--★★グリートーネア★★:想い人ですか、ルーシャス様？
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01A110_020048")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:悲恋だったよ<br>身を焦がすほどのな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A110_020050")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101045","001","101045001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
