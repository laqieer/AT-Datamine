-- このluaスクリプトは、MA_01104_36.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_007)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ラグネル★★:あたし、思うんだけど<br>急いでるんじゃないかなって
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360002")


	--★★ラグネル★★:ノワールはもうキラーズを得て<br>一応は円卓の騎士としての地位も認められた
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360003")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラグネル★★:かたやディナタンちゃんは<br>いわばカヤの外のような状態なわけでしょ？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:兄として妹の安全を守りたいっていう<br>ノワールの気持ちもわかるよ
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360005")

	change_face(Actor003,"Normal")

	--★★ラグネル★★:でもね？彼女のほうとしてもその立場で<br>甘んじ続けるのは焦れるっていうかさ
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360006")


	--★★ガウェイン★★:わりぃ、２行でまとめてくれ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01104_360007")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラグネル★★:・ディナタンちゃん、療養院で働く<br>・そしてこのたび非行少女と儀式へ赴く
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01104_360009","MA_01104_360010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンを問い詰めよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_360012")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:だめだよノワール！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360013")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★ラグネル★★:ヒミツにしてることを尋ねたって<br>かたくなになるだけだって！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:見守るべきか…？<br>ディナタンの決めたことなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_360016")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:まぁここまで秘密にされてるってことはなあ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01104_360017")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ラグネル★★:知られたくないし、心配かけたくないんだろうね<br>あるある、そういうことあるある
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360018")

	goto Block1end

::Block1end::
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ノワールもついて行っちまえばいいんじゃねえ？<br>そんなに心配なら
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01104_360020")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺が？黙って？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_360021")

	PlayAction(Actor003,"to Greet_one")
	change_face(Actor003,"Smile")

	--★★ラグネル★★:それイイね！<br>あたしもガウェインに賛成！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ガウェイン★★:妹さんも黙って<br>色々決めちまったわけだろ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01104_360023")

	change_face(Actor001,"Sad")

	--★★ノワール★★:アーサーやケイがなんて言うか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_360024")

	change_face(Actor003,"Normal")

	--★★ラグネル★★:ノワールって変なところで真面目だね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360026")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ガウェイン★★:アーサー様、日程を念押ししてさあ<br>「ちゃんと連れて行くんだぞ」っつったんだろ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01104_360027")

-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ラグネル★★:うん
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360028")


	--★★ガウェイン★★:で、ラグネル<br>お前は外でそれを盗み聞きしてたと
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01104_360029")


	--★★ラグネル★★:うん。あっ、でも盗み聞きじゃないよ<br>たまたま聞いちゃっただけだからね？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360030")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:アーサー様がそれ…<br>わかんないでいると思うか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01104_360032")

	change_face(Actor003,"Surprise")

	--★★ラグネル★★:うん？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360033")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力

	--★★アーサー★★:ニッ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01104_360035")

	open_cutin(3,1)
	on_cutin(1,Actor002,"Surprise")
	on_cutin(2,Actor001,"Surprise")
	on_cutin(3,Actor003,"Surprise")
-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
	close_cutin()

	--★★ラグネル★★:あー
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360036")

-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…なるほど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_360037")

	change_face(Actor003,"Normal")

	--★★ラグネル★★:学園生徒の安全を守るのが円卓の騎士の仕事<br>妹の成長を見守るのが兄の仕事
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360038")

	change_face(Actor003,"Smile")

	--★★ラグネル★★:大変だね～<br>後悔してない？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360039")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:…やりがいを感じてきたところだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_360041")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラグネル★★:ナイスな兄貴じゃねえの～
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01104_360043")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
