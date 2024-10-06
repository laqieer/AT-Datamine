-- このluaスクリプトは、CO_101011_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_003)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor001, Actor002, "J_Head")
lookat_delay_weight(Actor001, 1.0, 0.5, 0.5, 0.2,1.0)
lookat_delay_weight(Actor002, 0.2, 0.05, 0.2, 0.2,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん、ここにもないか<br>次はどこを探す、ギネヴィア？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_08020002")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
wait_time(1.3)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィア？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_08020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:…キャメリアードが危ないかもってなってさ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:うん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_08020006")


	--★★ギネヴィア★★:わたしとお姉ちゃんは<br>ログレスに保護されたんだけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020007")


	--★★ギネヴィア★★:わたし<br>しばらく部屋にこもって泣いてた
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020008")


	--★★ギネヴィア★★:いくらパパの言いつけだからって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:突然アーサーと婚姻を結べって言われても<br>納得できないし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020011")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:そもそも<br>わたしの居場所はログレスじゃない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:お姉ちゃんと一緒にパパのところに帰りたい<br>そう思って、ずっと泣いてた
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020015")


	--★★ギネヴィア★★:そしたらお姉ちゃんが<br>学園への入学を勧めてくれたの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:「一緒に強くなりましょう」って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020017")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:バルバロイは怖かったし<br>…まぁ、今も怖いんだけど…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:お姉ちゃんが励ましてくれたから頑張れた<br>儀式も済ませて、毎日勉強して…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:着慣れないドレスだって着て<br>王妃様らしく振る舞って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020020")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:…わたしの運命の相手がお姉ちゃんだって<br>わかったとき、すごく嬉しかった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020021")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:キャメリアードに居座るバルバロイを倒そうって<br>誓って一緒に喜んでたら
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020023")


	--★★ギネヴィア★★:パァーって紋章が共鳴して…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020024")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ゲシュタルト・シフトに<br>至ったわけか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_08020025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:うん、でもね<br>わたしがマスターだったの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020026")


	--★★ギネヴィア★★:お姉ちゃんのほうが強いのに<br>引っ張る側はお姉ちゃんのほうがいいのに
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020027")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:だから<br>またわたし泣いちゃって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020028")


	--★★ギネヴィア★★:そしたらね<br>お姉ちゃんがこう言ってくれたの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:「マスターとキラーズの<br>どっちが優秀かなんてないの」
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020030")


	--★★ギネヴィア★★:「私たちはふたりでひとつ<br>これからずっと一緒にいられるの」って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101011_08020033","CO_101011_08020034")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:優しいお姉さんだな<br>ギネマウアさん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_08020036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:うん、すっごく優しいよ<br>小さいときからずっと
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020037")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:わたしのことを見守ってくれる<br>自慢のお姉ちゃんなんだ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020038")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺もそう思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_08020040")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:マスターとキラーズの最大の武器は絆<br>どっちが上とか考えちゃいけない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_08020041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:そうだよね<br>お姉ちゃんに言われて恥ずかしくて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020042")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:そのあとね<br>あの魔法のガラス玉をくれたの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020044")


	--★★ギネヴィア★★:「私たちはふたりでひとつになったんだから<br>もうどっちが持っていてもいいよね」
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:「もう泣かないって約束してくれるなら<br>これからはギネヴィアが持っていて」って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020046")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だから<br>大切にしていたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_08020047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:うん<br>だから絶対になくせないの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_08020048")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:見つけ出そう、必ず
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_08020049")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ギネヴィア_ランクアップ8_3")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(110151)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 1
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
