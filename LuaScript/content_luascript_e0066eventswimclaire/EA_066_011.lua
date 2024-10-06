-- このluaスクリプトは、EA_066_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_03","110111_03_h")
Include("content_adv_advsmall_110111_03","Template110111_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor002",nil,CharaPos110111_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_003)
	Camera002 = SetTemplate("Actor003",124,CharaPos110111_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_006)
	Camera003 = SetTemplate("Actor004",nil,CharaPos110111_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_005)
	Camera004 = SetTemplate("Actor005",nil,CharaPos110111_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_001)
	InitializeTemplateRandomCamera110111_03()
	InitializeTemplate110111_03()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
turn_lookat(Actor002,Actor003,0)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight(Actor003,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
set_pos(Actor004,{-5.242,0,-22.832})
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
set_pos(Actor005,CharaPos110111_03_101)
-- ▲直接出力
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
show_image("101010150", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
load_image("101030140", "content_still_10103014_image", "101030140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Noon")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_General1_Intro")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:ブリテン島六世紀
	Talk(Actor001,"","simple","N","EA_066_0110002")


	--★★テロップ★★:皇太子ルーシャス率いるローマとの間に<br>聖杯を巡る争いが勃発
	Talk(Actor001,"","simple","N","EA_066_0110004")


	--★★テロップ★★:バルバロイを味方につけたローマとの戦は<br>苛烈を極めるも遂にログレスは戦を制し
	Talk(Actor001,"","simple","N","EA_066_0110005")


	--★★テロップ★★:そして継承者とその劔は遂に聖域化を成し遂げた
	Talk(Actor001,"","simple","N","EA_066_0110006")


	--★★テロップ★★:世界からバルバロイの脅威は打ち払われ<br>次へと継がれたのだ
	Talk(Actor001,"","simple","N","EA_066_0110007")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, 0.5)
wait_time(0.5)
show_image("101030140", 0.0, 0.0, 0.0,true,false)
wait_time(0.1)
fadein(0.5)
wait_time(0.5)
-- ▲直接出力

	--★★テロップ★★:これは、継がれた先の物語
	Talk(Actor001,"","simple","N","EA_066_0110009")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
hide_image(0.0)
setup_small_camera_start(RndCamera001)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(1)
setup_small_camera_end(RndCamera001)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Area_Noon")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0025")
-- ▲直接出力

	--★★パーシヴァル★★:まったく、参っちゃうよねえ！<br>皆して自分たちの利益の主張ばかりで
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディンドラン","0007")
-- ▲直接出力

	--★★ディンドラン★★:そうですね、パーシヴァル様
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_066_0110013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0019")
-- ▲直接出力

	--★★パーシヴァル★★:今考えるべきは庶民の生活だってことくらい<br>貴族ならわかりそうなものだけどねえ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110014")


	--★★パーシヴァル★★:本当に勝手なんだからさ！<br>ああ、まったく嘆かわしいったらないよ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110015")


	--★★パーシヴァル★★:そう思わないかい！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110016")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ディンドラン","0011")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:ええ。パー坊が誇り高い貴族に育ってくれて<br>胸がいっぱいだわ…
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_066_0110017")

	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:今そういう話してないんだけど！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110018")

-- ▼直接出力
local gopos = {-0.473, 0, -18.408}
CloseTalkWindow()
Appear(Actor004)
turn_lookat_position(Actor004, gopos, 0)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004, gopos, 2.4)
wait_time(1.4)
setup_small_camera_end()
setup_small_camera_start(Camera003)
wait_time(1)
PlayActionDirect(Actor004,"to Std_Loop")
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
lookat_delay_weight(Actor004,0.5,0.1,0.8,0.2,1.0)
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor003, true)
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101024_sp_0005_1")
-- ▲直接出力

	--★★ヴォールス★★:パーシヴァル、戻っていたのか
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110020")

-- ▼直接出力
setup_small_camera_end(Camera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0008")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:まぁ、またすぐに出かけるけどね<br>まったく、アーサー王は本当に人使いが荒いよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110021")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0008")
-- ▲直接出力

	--★★ヴォールス★★:それだけお前のことを頼りにしているのだろう
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110022")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★ヴォールス★★:先の戦いでローマが衰退したことにより<br>両国間の緊張はようやく落ち着いた
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110023")

	change_face(Actor004,"Sad")

	--★★ヴォールス★★:ルーシャス派のローマ兵が一部離反している<br>という話は気にかかるが…
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110024")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディンドラン","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:はい。彼らはロンディニウムの一件を<br>いまだログレスの仕業と信じています
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_066_0110025")


	--★★ディンドラン★★:そしてルーシャスにこそ正義があるのだと<br>主張し、独自に動いているようで
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_066_0110026")

-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:まぁ、引き下がれなくなってるんだろうね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110027")


	--★★パーシヴァル★★:大陸に戻ったところで<br>敗残兵の彼らに居場所はないだろうし
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110028")

-- ▼直接出力
setup_small_camera_end(RndCamera002)
-- ▲直接出力

	--★★パーシヴァル★★:それに…こんなことを言うのはなんだけど<br>彼には人を惹きつける力があった
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110029")


	--★★パーシヴァル★★:行き詰まった大帝国の未来を切り開くという<br>彼の意志に希望を見出した人間も多いだろうし
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110030")


	--★★パーシヴァル★★:そいつらにとっては<br>今も彼こそが皇太子なのさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110031")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0008")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ヴォールス★★:一度見てしまった<ruby=ゆめ>幻想</ruby>を捨てるのは<br>そう簡単なことではない、か
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110032")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ディンドラン★★:…とはいえ、それはあくまで一部の話<br>数自体はそう多くはないと聞いています
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_066_0110034")


	--★★ディンドラン★★:いずれは事態の収拾を図ろうとする<br>本国に抑え込まれるでしょう
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_066_0110035")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0034")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ヴォールス★★:だといいが…
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110036")

-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0008")
-- ▲直接出力

	--★★パーシヴァル★★:まぁ警戒は怠るべきじゃないだろうね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110037")


	--★★パーシヴァル★★:それに、ローマに限らず<br>いつまた他の脅威が襲ってくるかもわからない
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110038")

-- ▼直接出力
setup_small_camera_end(RndCamera002)
-- ▲直接出力

	--★★パーシヴァル★★:だから周辺国とは密に連携をとって<br>侵略に備える必要がある
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110039")

	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:ログレスを盟主とした協力体制の同盟を結び<br>他国の貴族たちとも上手く関係を築いて――
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110040")


	--★★パーシヴァル★★:そんな大仕事を任せられるのは<br>このぼくを置いて他にはない！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110041")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ディンドラン","0011")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:立派、立派よパー坊<br>義姉さん泣いちゃいそう！
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_066_0110042")

-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0018")
-- ▲直接出力

	--★★パーシヴァル★★:茶化すな！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110043")

-- ▼直接出力
PlayPartVoiceDirect("ディンドラン","0040")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:あら、茶化してなんかいませんよ
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_066_0110044")


	--★★ディンドラン★★:私は本気で思っていますから<br>貴方が誇らしい、と
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_066_0110045")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
PlayPartVoiceDirect("ヴォールス","0038")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ヴォールス★★:俺もそう思っている。お前は立派だ
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110046")

-- ▼直接出力
setup_small_camera_end(RndCamera002)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ヴォールス★★:…お前だけじゃない。トリスタンとイゾルデは<br>以前から続けていた奉仕活動により精を出し
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110047")


	--★★ヴォールス★★:ガウェインとラグネルは<br>ログレス国防の要とすべく騎士団の育成に尽力
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110048")


	--★★ヴォールス★★:他も皆――己の為すべきことを見据え<br>前に進んでいる
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110049")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:まあ、立ち止まっているより動いていた方が<br>気が紛れるってのもあるかもだけどね　
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110050")


	--★★ヴォールス★★:…ノワールのことか
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0008")
-- ▲直接出力

	--★★パーシヴァル★★:ああ、そうだよ。せっかくぼくの仕事を<br>手伝う名誉を与えようと思ったのにさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110052")

-- ▼直接出力
PlayPartVoiceDirect("ディンドラン","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:断られて拗ねてましたよね、パー坊
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_066_0110053")

	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:拗ねてない！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110054")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:放浪の旅、だっけ？<br>まったく、庶民の考えることはわからないよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110055")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力

	--★★パーシヴァル★★:…まぁ、でも――それが少しでも慰めになるなら<br>世界中だろうが巡ったらいいと思うけどさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110056")


	--★★パーシヴァル★★:寄り添えないんだからさ<br>覚えてないぼくたちじゃ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110057")

	change_face(Actor004,"Sad")

	--★★ヴォールス★★:………
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101027_sp_0002_1")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:パーシヴァル様、そろそろ
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_066_0110059")

	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:ん？ああ、もう行く時間か
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110060")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0037")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ヴォールス★★:すまんな、呼び止めてしまって
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110061")

-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0038")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:それは別に構わないけど<br>ところで。キミは今、なにを？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110062")


	--★★ヴォールス★★:俺は…
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110063")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
local gopos = {1.357, 0, -17.108}
CloseTalkWindow()
Appear(Actor005)
turn_lookat_position(Actor005, gopos, 0)
PlayActionDirect(Actor005,"to Run")
slidemove(Actor005, gopos, 1)
wait_time(0.8)
setup_small_camera_end()
setup_small_camera_start(Camera004)
wait_time(0.2)
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_General1_Intro")
-- ▲直接出力

	--★★ログレス兵★★:ヴォールス卿！街道に獣の群れが出て<br>人に危害を与えているとの報告が！
	Talk(Actor005,"NPCNAME_0124","speech","N","EA_066_0110064")

-- ▼直接出力
setup_small_camera_end(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0039")
-- ▲直接出力

	--★★ヴォールス★★:わかった。すぐに向かう
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110065")

-- ▼直接出力
local gopos = {2.496,0,-14.084}
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor005,"to Run")
turn_lookat_position(Actor005, gopos, 0.2)
wait_time(0.2)
slidemove(Actor005, gopos, 0.8)
wait_time(0.8)
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力

	--★★パーシヴァル★★:相変わらず、ってこと？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_066_0110066")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力

	--★★ヴォールス★★:ああ。俺はログレスを守っている
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110067")


	--★★ヴォールス★★:前と同じだ。なにも変わらん
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_066_0110068")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101030140", "content_still_10103014_image", "101030140_StillImage")
preload_sound("BGM_Area_Noon")
preload_sound("BGM_Battle_General1_Intro")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
