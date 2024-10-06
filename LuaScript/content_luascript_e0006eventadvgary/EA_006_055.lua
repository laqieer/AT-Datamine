-- このluaスクリプトは、EA_006_055.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114093_01","114093_01_h")
Include("content_adv_advsmall_114093_01","Template114093_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114093_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName114093_01,CameraPos114093_01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114093_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName114093_01,CameraPos114093_01_004)
	Camera003 = SetTemplate("Actor004",nil,CharaPos114093_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName114093_01,CameraPos114093_01_008)
	InitializeTemplateRandomCamera114093_01()
	InitializeTemplate114093_01()
-- ▼直接出力
set_pos(Actor002,{4.18, 0, -1.069})
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-5.74, 0, -0.062})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
load_image("201010070", "content_still_20101007_image", "201010070_StillImage")
-- ▲直接出力
-- ▼直接出力
Camera_EX = set_camera({0.84, 1.39, 0.92,   359.5589, 158.0661, 0,   30.36516})
-- ▲直接出力
-- ▼直接出力
load_image("104000310", "content_still_10400031_image", "104000310_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114093)
	Actor001 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101015","001","101015001")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_No")

	--★★ガレス★★:………あーあ、ぐっちゃぐちゃ
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550003")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガレス★★:（いくらなんでもこれじゃ、渡せないよ）
	Talk(Actor001,"CHRNAME_GARETH","mind","L","EA_006_0550004")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
Appear(Actor002)
IN_WALK(Actor002,CharaPos114093_01_004)
wait_time(1.2)
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0002")
-- ▲直接出力

	--★★ガウェイン★★:なにしょぼくれてんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550006")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002,0.4)
wait_time(0.4)
setup_small_camera_start(RndCamera090)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_006_0550009","EA_006_0550010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ガレス★★:…ごめん、兄さん
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550013")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ん？なにが？<br>お前、なんか悪いことしたっけ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ガレス★★:…ありがと、兄さん
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550017")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:いいよ、礼なんて<br>当たり前のことしただけなんだから
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:家族を守るのは当然のことだろ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550019")

	goto Block1end

::Block1end::
	change_face(Actor001,"Sad")

	--★★ガレス★★:………
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550021")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:まだヘコんでんのか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550022")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Surprise")

	--★★ガレス★★:…だって、戦っている最中に気を散らすなんて<br>兄さんがいなかったらどうなってたか――
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガレス★★:悔しいな…あんなにでかいこと言ったのに<br>やっぱり、わたしは全然、まだまだだな
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550024")


	--★★ガウェイン★★:んなことねーよ<br>あれだけの兵とバルバロイを相手にしたんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:もっと胸張れって
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550026")


	--★★ガレス★★:でも…
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550027")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:むしろ俺のほうこそ、見くびってて悪かったな<br>あそこまでやれるなんて思ってなかったぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550028")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:お前は俺が守らなきゃって<br>そう思ってたのにさぁ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0010")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:あっという間にこんなに強くなって<br>すげーよ、お前は
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550030")

	change_face(Actor001,"Surprise")

	--★★ガレス★★:兄さん…
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:…ま、確かに戦場で気を抜くのは<br>いただけねーなとは思うけど
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:それは次から気を付けろよな<br>――円卓の騎士を名乗るならさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550033")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ガレス★★:………！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550034")

	change_face(Actor001,"Laugh")

	--★★ガレス★★:認めて、くれるのか？
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550035")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0034")
-- ▲直接出力

	--★★ガウェイン★★:…まー、本音を言えば、やっぱ心配だし<br>嫌ではあるよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:俺、お前にはもう<br>危険な目にあってほしくねーんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550037")


	--★★ガウェイン★★:家族、大事だからさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガウェイン★★:だから、戦いからは<br>なるべく遠いところにいてほしかった
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550039")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガウェイン★★:せめて、俺の後ろにいてくれりゃあいい<br>そうすりゃ俺が守れるからって
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550040")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ガレス★★:兄さん…
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:…けどお前の頑張りを見て、思ったんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:妹のやりたいことを応援できなきゃ<br>兄貴失格だよな――って
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550043")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Smile")

	--★★ガレス★★:兄さん…！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:あー…腹減った！<br>弁当、もらうぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550045")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
setup_small_camera_start(RndCamera001)
ShowImageItem(104000310)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Surprise")

	--★★ガレス★★:あ…駄目だ！これ、ぐちゃぐちゃになっちゃって<br>別のやつ、もらってくるから
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550046")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550047")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
set_enable_auto_lookat(Actor002,false)
HideImageItem(104000310)
wait_time(0.6)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.4)
wait_time(0.4)
slidemove(Actor002,{0.14, 0, 0.53}, 1.4)
wait_time(1.4)
PlayActionDirect(Actor002,"to  Std_No")
wait_time(1.0)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,130,0.4)
wait_time(0.4)
slidemove(Actor002,{1.656, 0, -1.069}, 1.4)
wait_time(1.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.8)
setup_small_camera_start(Camera_EX)
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor002,"to Cough")
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:もぐもぐもぐ…あー、やっぱうめーな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550049")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:すげーな。どこを食ってもうめーから<br>混ざってても最高にうめーわ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550050")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")

	--★★ガレス★★:…！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550051")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
PlayActionDirect(Actor002,"to Cough")
wait_time(1.4)
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガレス★★:…当たり前だろ。兄さんの好きなものだけ<br>たくさん入れてるんだから
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550053")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.8)
Appear(Actor004)
IN_WALK(Actor004,CharaPos114093_01_008)
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★ランスロット★★:仲直りはできたようだな
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0550055")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start()
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor004,0.6)
wait_time(0.6)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor004,0.5)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.8)
set_enable_auto_lookat(Actor002,true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0007")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガレス★★:ランスロットのおかげだ<br>いっぱい手伝ってもらったからな
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550056")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★ランスロット★★:大したことはしていない
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0550057")


	--★★ランスロット★★:ガウェインを認めさせたのも<br>バラバラだった円卓をひとつにしたのも
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0550058")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Wlk")
turn_lookat(Actor004,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0010")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ランスロット★★:料理で人と人を繋ぐことが出来る<br>お前だからできたことだ
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0550059")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Smile")

	--★★ガレス★★:ランスロット…！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550060")


	--★★ガウェイン★★:？<br>あれ、ランスロットは食わねーの？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550061")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:このサンド、アンチョビが効いててうめーぞ<br>ブルーチーズのソースもキく～！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_006_0550062")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ランスロット★★:あ、ああ…俺は…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0550063")

	PlayAction(Actor001,"to Show")

	--★★ガレス★★:ランスロットにはこれを食べてほしいんだ<br>ガレス特製・ランスロットスペシャルサンド！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550064")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Surprise")

	--★★ランスロット★★:スペシャルサンド…！？
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0550065")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0011")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガレス★★:これならランスロットもイケると思うから<br>食べてみてくれ～♪
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0550066")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ランスロット★★:…わかった
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0550067")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
show_image("201010070",0.0,0.0, STILL_SWITCH_TIME ,true,true)
set_scale_image(0.6154,0.6154)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ランスロット★★:…美味い
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","EA_006_0550079")

	change_face(Actor001,"Normal")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","simple","N","EA_006_0550080")


	--★★ガレス★★:アンチョビには刻んだハーブを混ぜて<br>臭みをとったんだ！
	Talk(Actor001,"CHRNAME_GARETH","simple","N","EA_006_0550081")


	--★★ランスロット★★:なるほどな…とても美味しい<br>ありがとう、ガレス
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","EA_006_0550082")


	--★★アーサー★★:
	Talk(Actor003,"CHRNAME_ARTHUR","simple","N","EA_006_0550083")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力

	--★★アーサー★★:ズルいぞ！俺にもソースギトギト味濃いめの<br>特製アーサーサンドを作ってくれ！
	Talk(Actor003,"CHRNAME_ARTHUR","simple","N","EA_006_0550084")

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0025")
-- ▲直接出力

	--★★ランスロット★★:聞いてるだけで胸焼けしそうだ
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","EA_006_0550085")

-- ▼直接出力
PlayPartVoiceDirect("ガレス","0009")
-- ▲直接出力

	--★★ガレス★★:それはまた今度――
	Talk(Actor001,"CHRNAME_GARETH","simple","N","EA_006_0550086")


	--★★ガレス★★:また来年…皆でお花見するときに！
	Talk(Actor001,"CHRNAME_GARETH","simple","N","EA_006_0550087")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	EndPlay()
end

