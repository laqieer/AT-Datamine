-- このluaスクリプトは、EA_006_023.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor002",nil,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	Camera002 = SetTemplate("Actor003",nil,CharaPos110122_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_006)
	Camera003 = SetTemplate("Actor004",40,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★ガレス★★:（…あのとき、兄さんは私にそう言ってくれた<br>家族を大事にするのは当然だって）
	Talk(Actor002,"CHRNAME_GARETH","mind","L","EA_006_0230002")


	--★★ガレス★★:（家族を――大切な人たちを守りたいと思って<br>学園に来たわたしにはそんな兄さんが眩しくて）
	Talk(Actor002,"CHRNAME_GARETH","mind","L","EA_006_0230003")


	--★★ガレス★★:――ヒーローみたいって、思ったんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0230004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:ヒーロー？
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0230005")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガレス★★:バルバロイに襲われたわたしの故郷に<br>颯爽と現れて家族を助けてくれた円卓の騎士
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0230006")


	--★★ガレス★★:眩しいくらいまっすぐで<br>いつだって誰かを守ることに全力で
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0230007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ガレス★★:それから…誰かを大切にすることに<br>何のてらいもなくて――
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0230008")


	--★★ガレス★★:…そんなヒーローに憧れて、近づきたくて<br>一緒に頑張りたくて、円卓の騎士を目指したんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0230009")

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0021")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ランスロット★★:………
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0230010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
voice_play("VO_101032_sp_0005_3")
-- ▲直接出力

	--★★ガレス★★:わたしの気持ち、分かってくれてると思ってた<br>なのに…――酷い…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0230011")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0008")
-- ▲直接出力

	--★★ランスロット★★:…ガウェインに悪気はないのだと思う
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0230012")

	change_face(Actor004,"Normal")

	--★★ランスロット★★:ただ兄として、妹に<br>危険な役目を負ってほしくはないのだろう
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0230013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0033")
-- ▲直接出力

	--★★ガレス★★:それを言ったら妹だって<br>兄に危険な役目を負ってほしくはない
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0230014")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ガレス★★:それでもあんな風に頭ごなしに反対なんかしない
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0230015")

	change_face(Actor004,"Sad")

	--★★ランスロット★★:それは…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0230016")


	--★★ガレス★★:この学園に来たときからどんな危険も覚悟してる<br>その上でリオネスと頑張ってきたんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0230017")


	--★★ガレス★★:それなのに――
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0230018")


	--★★ランスロット★★:ガレス…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0230019")

-- ▼直接出力

setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0016")
-- ▲直接出力

	--★★ガレス★★:…もう、頭きた！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0230020")


	--★★ガレス★★:こうなったら兄さんが認めざるを得ないくらい<br>結果を出してやるからな～！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0230021")

	PlayAction(Actor002,"to  Std_Joy")

	--★★ガレス★★:なんか燃えてきたぞ！<br>リオネス！それ食べ終わったら見回りだ～！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0230022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("リオネス","0009")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:もぐもぐもぐ…ごくん。わかった！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_006_0230024")

	open_cutin(2,2)
	on_cutin(1,Actor003,"Anger")
	on_cutin(2,Actor002,"Anger")

	--★★ガレス／リオネス★★:
	Talk(Actor001,"CHRNAME_GARETH_LYONESS","speech","L","EA_006_0230025")

	close_cutin()
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0010")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ランスロット★★:…課題も忘れずにな
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0230026")

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
	InitializeCharacter_3D_Preload("101032","002","101032002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
