-- このluaスクリプトは、EA_004_013.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",250,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera003 = SetTemplate("Actor005",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	Camera004 = SetTemplate("Actor006",nil,CharaPos110051_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_006)
	Camera005 = SetTemplate("Actor007",210,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera006 = SetTemplate("Actor008",nil,CharaPos110051_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_008)
	Camera007 = SetTemplate("Actor009",nil,CharaPos110051_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_001)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
lookat_weight(Actor001,0.5,0.1,0.85,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor005,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor005,0.45,0.1,0.85,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
lookat_weight(Actor007,0.45,0.1,0.85,0.2)
keep_ik_lookat(Actor007,Actor005,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
keep_ik_lookat(Actor008,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor009, false)
keep_ik_lookat(Actor009,Actor005,"J_Head")
-- ▲直接出力
-- ▼直接出力
load_image("103040030", "content_still_10304003_image", "103040030_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101056","001","101056001")
	Actor004 = InitializeCharacter_2DOnly("101015","001","101015001")
	Actor005 = InitializeCharacter_3D("101054","005","101054005","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor009")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ケイ","悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:支援の申し出をあのような形で突っぱねておいて<br>誠に申し訳ない話だが…
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_004_0130002")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_1")
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
  --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103040030", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
setup_small_camera_start()
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ペレス★★:継承者が完全に覚醒した以上<br>これが最後の戦いとなろう
	Talk(Actor003,"CHRNAME_PEREZ","simple","N","EA_004_0130004")


	--★★ペレス★★:我らが力を合わせねばならぬ時期が<br>来ていることは理解しておるつもりだ
	Talk(Actor003,"CHRNAME_PEREZ","simple","N","EA_004_0130005")


	--★★アーサー★★:
	Talk(Actor004,"CHRNAME_ARTHUR","simple","N","EA_004_0130006")


	--★★ノワール★★:アーサー…？
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_004_0130007")


	--★★アーサー★★:妖精や伝承…不確かなものにすがり続け<br>ペレス王にも心労をかけた
	Talk(Actor004,"CHRNAME_ARTHUR","simple","N","EA_004_0130008")


	--★★アーサー★★:確かな伝説を<br><dot>人</dot>が創っていかねばなるまい
	Talk(Actor004,"CHRNAME_ARTHUR","simple","N","EA_004_0130009")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
change_face(Actor001,"Sad")
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
--エフェクト終了
hide_image() 
--スチル終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
setup_small_camera_start(Camera001)
wait_time(IMAGE_TIME_OUT_IN)
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★アダン★★:お気になさらず<br>起きてしまったことはもはや仕方のないこと
	Talk(Actor005,"CHRNAME_ADAM","speech","L","EA_004_0130014")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アダン","肯定2")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★アダン★★:過ぎたことを憂うよりも、これからを<br>どう戦うかに意識を向けていくべきでしょう
	Talk(Actor005,"CHRNAME_ADAM","speech","L","EA_004_0130015")


	--★★アダン★★:自分の経験が少しでも<br>貴公らの力になれるなら幸いです
	Talk(Actor005,"CHRNAME_ADAM","speech","L","EA_004_0130016")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ケイ★★:…感謝する
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_004_0130017")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★エクセリア★★:
	Talk(Actor006,"CHRNAME_EXCELIA","speech","L","EA_004_0130018")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","笑い")
-- ▲直接出力

	--★★エクセリア★★:戦術の知識が豊富なのは勿論だけれど<br>アダンは人に教えることも上手だから
	Talk(Actor006,"CHRNAME_EXCELIA","speech","L","EA_004_0130019")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アダン","否定")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★アダン★★:エクセリア…そうハードルを上げないでください
	Talk(Actor005,"CHRNAME_ADAM","speech","L","EA_004_0130020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("エクセリア","0019")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★エクセリア★★:？事実を言っているだけだわ<br>学園祭の準備期間だけの指導じゃ惜しいくらいよ
	Talk(Actor006,"CHRNAME_EXCELIA","speech","L","EA_004_0130021")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:エクセリアがそこまで言うんだ<br>アダン先生の授業を受けるのが楽しみだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130023")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット","肯定")
-- ▲直接出力
	change_face(Actor007,"Laugh")

	--★★ランスロット★★:ああ。熟練の騎士の実戦経験に基づいた指導を<br>受けられる機会はそう多くない
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","EA_004_0130024")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力

	--★★ランスロット★★:これからの戦いにも活かせることだろう
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","EA_004_0130025")

-- ▼直接出力
set_enable_auto_lookat(Actor007, true)
-- ▲直接出力
	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ","肯定3")
-- ▲直接出力

	--★★リリアーナ★★:私たちも微力ながら<br>皆さんの助けになれればと思います
	Talk(Actor008,"CHRNAME_LILIANA","speech","L","EA_004_0130026")

	PlayAction(Actor008,"to  Std_Talk")
	change_face(Actor008,"Sad")

	--★★リリアーナ★★:でも…大丈夫なんでしょうか<br>いつまた襲撃があるかわからないんですよね？
	Talk(Actor008,"CHRNAME_LILIANA","speech","L","EA_004_0130027")

-- ▼直接出力
PlayPartVoice("リリアーナ","落胆")
-- ▲直接出力

	--★★リリアーナ★★:そんな時期に、学園祭なんて…
	Talk(Actor008,"CHRNAME_LILIANA","speech","L","EA_004_0130028")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:そうね。人の出入りが多くなれば<br>それだけ敵の侵入リスクも増える
	Talk(Actor006,"CHRNAME_EXCELIA","speech","L","EA_004_0130029")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)

	--★★エクセリア★★:防衛に割ける人員が少ない今の段階での<br>学園祭開催は最適解ではないんじゃないかしら
	Talk(Actor006,"CHRNAME_EXCELIA","speech","L","EA_004_0130030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それは――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:ふたりの懸念はもっとも
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_004_0130032")


	--★★ケイ★★:だが学園祭を通して学園全体を盛り上げたい<br>という殿下の考えも汲んでいただければと
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_004_0130033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:辛い時だからこそ、楽しい思い出を<br>この学園にあったはずの青春を取り戻したい
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_004_0130034")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ","否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:…いや、そうするべきなのだ<br>青春は、生徒たちの力になるものだからな
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_004_0130035")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor007, false)
-- ▲直接出力
	change_face(Actor009,"Sad")

	--★★マーリン★★:ケイ…
	Talk(Actor009,"CHRNAME_MERLIN","speech","L","EA_004_0130036")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor007, true)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","挨拶")
-- ▲直接出力

	--★★エクセリア★★:
	Talk(Actor006,"CHRNAME_EXCELIA","speech","L","EA_004_0130037")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？そうだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_004_0130040","EA_004_0130041")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:例えば友達と一緒に勉強したりケンカしたり<br>一緒に美味い飯を食って、笑ったり…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130044")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういう、同世代の友人との<br>なにげない瞬間…とかかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130045")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","悩む")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★エクセリア★★:同世代であることが大事なの？
	Talk(Actor006,"CHRNAME_EXCELIA","speech","L","EA_004_0130046")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まぁ、やっぱり多少意識はするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130047")

-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:同世代ががんばっている姿を見ると<br>負けてられないって思うしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130048")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★エクセリア★★:そういうものなのね…
	Talk(Actor006,"CHRNAME_EXCELIA","speech","L","EA_004_0130049")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それはやっぱ、好きな人と過ごしたり…<br>とかじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130052")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","肯定")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★エクセリア★★:過ごすって具体的には？　
	Talk(Actor006,"CHRNAME_EXCELIA","speech","L","EA_004_0130053")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？そうだなぁ…相手の部活を見に行ったりとか<br>放課後デートしたりとか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130054")

	change_face(Actor007,"Smile")

	--★★ランスロット★★:ほう
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","EA_004_0130055")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…一般論だよ、一般論！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130056")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("エクセリア","納得")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★エクセリア★★:なるほどね。私はこういう場所を知らないから<br>あまりよくわからないけど…
	Talk(Actor006,"CHRNAME_EXCELIA","speech","L","EA_004_0130058")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:でも、大切なものだというなら<br>護るべきだと思うわ
	Talk(Actor006,"CHRNAME_EXCELIA","speech","L","EA_004_0130059")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor007, false)
-- ▲直接出力

	--★★アダン★★:…
	Talk(Actor005,"CHRNAME_ADAM","speech","L","EA_004_0130061")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor007,Actor001,"J_Head",1.0)
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット","挨拶")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ランスロット★★:そういえば…<ruby=ヴァンデル・ピーク>『遥か望む剣』</ruby>は<br>学園祭でなにをやるか決まったのか？
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","EA_004_0130063")

-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギクッ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130065")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット","肯定3")
-- ▲直接出力

	--★★ランスロット★★:模擬店はもう出店数が多いから<br>できれば別の物にしてもらえるとありがたいな
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","EA_004_0130067")


	--★★ランスロット★★:まぁ、もちろん決まってるならしかたないが…<br>…ノワール？
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","EA_004_0130068")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…実は、まだなにも決まってない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130070")

-- ▼直接出力
PlayPartVoice("ランスロット","驚き")
-- ▲直接出力
	change_face(Actor007,"Surprise")

	--★★ランスロット★★:なにも？もうあまり日にちが無いぞ<br>…大丈夫なのか？
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","EA_004_0130071")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:色々と忙しくってさ…<br>まぁ、大丈夫だよ。たぶんなんとかなる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130072")

-- ▼直接出力
PlayPartVoice("ランスロット","落胆")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★ランスロット★★:たぶんって、お前な…
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","EA_004_0130074")

-- ▼直接出力
set_enable_auto_lookat(Actor007, true)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, true)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","挨拶")
-- ▲直接出力

	--★★エクセリア★★:もし私たちにできることがあれば言って<br>喜んで手伝うわ
	Talk(Actor006,"CHRNAME_EXCELIA","speech","L","EA_004_0130076")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ","肯定2")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★リリアーナ★★:ええ。アダンのお手伝いをしているとき以外は<br>割と手が空くと思いますし
	Talk(Actor008,"CHRNAME_LILIANA","speech","L","EA_004_0130078")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:本当か！？ふたりが手伝ってくれるなら<br>そう焦る必要はなさそうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0130079")

-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
-- ▲直接出力
	play_head_motion(Actor007, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット","悩む")
-- ▲直接出力

	--★★ランスロット★★:…そう上手くいくといいがな<br> 
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","EA_004_0130081")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103040030", "content_still_10304003_image", "103040030_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101056","001","101056001")
	InitializeCharacter_2DOnly_Preload("101015","001","101015001")
	InitializeCharacter_3D_Preload("101054","005","101054005","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
