-- このluaスクリプトは、EA_006_016.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("リオネス","0045")
-- ▲直接出力

	--★★リオネス★★:…で、ガウェインと<br>取っ組み合いの大喧嘩をしてきたのか？
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","EA_006_0160002")

	open_select_window_tag(Actor002,"Normal","EA_006_0160004","EA_006_0160005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:え？なんで知ってるんだ？<br>ついさっきのことだぞ～
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リオネス","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★リオネス★★:偶然見かけた生徒から聞いたんだ<br>とんでもない激しい喧嘩だったって！
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","EA_006_0160009")

	change_face(Actor001,"Smile")

	--★★リオネス★★:学園中に広まるのも時間の問題だぞ
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","EA_006_0160010")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0024")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガレス★★:えええ、は、恥ずかしい～…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor002,"Sad")

	--★★ガレス★★:………
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★リオネス★★:反論しないってことは事実ってことか
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","EA_006_0160015")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0021")
SkipDefaultMotion(Actor002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:…円卓の騎士ともあろう者が周囲を巻き込んで<br>兄妹喧嘩なんて前代未聞だって
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160017")

	change_face(Actor002,"Sad")

	--★★ガレス★★:ケイに怒られちゃった～
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160018")

	change_face(Actor002,"Sad")

	--★★ガレス★★:別に好きで喧嘩したわけじゃないのに
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160019")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0023")
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:大体、兄さんが悪いんだ。あんな言いかた…<br>わたしたちの努力をなんだと思ってるんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガレス★★:…せっかく、兄さんと一緒の卓につけたのに<br>円卓の騎士になれたのに…まだ見習いだけど
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160022")


	--★★ガレス★★:それでも、お祝いにパーっとお花見でもとか<br>色々考えてたのにさ…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160023")

-- ▼直接出力
voice_play("VO_101033_sp_0002_3")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★リオネス★★:ガレス…
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","EA_006_0160024")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★ガレス★★:………
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160025")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★リオネス★★:で、でもでも！ガレスが円卓入りの第一歩を<br>踏み出した事実は変わらないだろ？
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","EA_006_0160026")


	--★★リオネス★★:ガウェインがなんて言おうと、なんたって<br>アーサー様がＯＫって言ってくれたんだ！
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","EA_006_0160027")

-- ▼直接出力
PlayPartVoiceDirect("リオネス","0047")
-- ▲直接出力

	--★★リオネス★★:見習いになることがまず難しいんだから<br>すごいことだと思うぞ！
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","EA_006_0160028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0008")
-- ▲直接出力

	--★★ガレス★★:うん。でも皆が皆認めてくれてるわけじゃない<br>…というより、正直ほとんど認められてない
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160029")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ガレス★★:このままじゃ、いつまでたっても<br>真の円卓の騎士になれない
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160030")

-- ▼直接出力
PlayPartVoiceDirect("リオネス","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★リオネス★★:う…それはそうかも
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","EA_006_0160031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0035")
SkipDefaultMotion(Actor002)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガレス★★:こうなったら…実力で認めさせるしかない！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160032")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★リオネス★★:どうやって？
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","EA_006_0160033")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力

	--★★ガレス★★:ケイに直談判して、円卓がやる予定の任務<br>片っ端からもらってくる！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160034")


	--★★ガレス★★:それを全部やりきって――証明するんだ<br>――わたしは円卓の騎士にふさわしいって！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0160035")

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
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","002","101032002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
