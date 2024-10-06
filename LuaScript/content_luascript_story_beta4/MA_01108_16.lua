-- このluaスクリプトは、MA_01108_16.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	Camera002 = SetTemplate("Actor002",200,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_005)
	Camera004 = SetTemplate("Actor004",20,CharaPos110122_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_003)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ガレス★★:つかみきれなかったのかなあ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01108_160002")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Anger")

	--★★リオネス★★:いや、味には問題なかったはずだぞ<br>ガレスはいつも通り、最高の調理をしていた
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_160003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あの…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_160004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガレス★★:飽きられちゃったのかなあ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01108_160005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★リオネス★★:なにを言うんだガレス！<br>あたしたちの最近のスローガンを忘れたのか！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_160006")

	change_face(Actor003,"Sad")

	--★★ディナタン★★:あの…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01108_160007")


	--★★リオネス★★:「レシピはあらゆるジャンルをカバー<br>飽きないメニューを食卓に」！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_160008")

	change_face(Actor002,"Anger")

	--★★ガレス★★:「味は高水準のキーパー<br>変わらぬ美味をその口に」！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01108_160009")

	open_cutin(2,1)
	on_cutin(1,Actor002,"Normal")
	on_cutin(2,Actor004,"Normal")

	--★★ガレス／リオネス★★:「「我ら食卓の騎士！<br>お腹の平和は任せとけ！」」
	Talk(Actor005,"CHRNAME_GARETH_LYONESS","speech","N","MA_01108_160011")

	close_cutin()

	--★★ノワール★★:おお～…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_160012")

-- ▼直接出力
turn(Actor002,0, 260,0,0.3)
-- ▲直接出力
-- ▼直接出力
turn(Actor004,0, -80,0,0.3)
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor002,"Normal")
	on_cutin(2,Actor004,"Normal")

	--★★ガレス／リオネス★★:ハッ──…！？
	Talk(Actor005,"CHRNAME_GARETH_LYONESS","speech","N","MA_01108_160014")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ディナタン★★:あの、そろそろ出る時間なので<br>迎えに来たんですけど…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01108_160015")

	change_face(Actor002,"Surprise")

	--★★ガレス★★:あ～！<br>忘れてたわけじゃないぞ、すぐ準備するから！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01108_160016")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Surprise")

	--★★リオネス★★:急げ！<br>捜索の期限はX日しかないんだぞ！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_160017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_160018")

	change_face(Actor004,"Normal")

	--★★リオネス★★:次の作戦もあるし、食堂も空けちゃうからな…<br>X日以内に見つからなきゃ捜索打ち切りなんだ！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_160019")


	--★★ディナタン★★:そんな…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01108_160020")


	--★★リオネス★★:買い出しのとき、街の人に聞いた話だと<br>ブライアンさんは北に走って行ったそうだ
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_160021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのケガだし、きっと痕跡は残ってるはずだ<br>どこかの村とかで休んでいるかもしれない…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_160022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガレス★★:胃袋をつかもう！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01108_160023")

	change_face(Actor003,"Surprise")

	--★★ディナタン★★:え？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01108_160024")

	PlayAction(Actor002,"to  Std_Joy")

	--★★ガレス★★:違う！言い直し！<br>手がかりをつかも～！！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01108_160025")

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
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
