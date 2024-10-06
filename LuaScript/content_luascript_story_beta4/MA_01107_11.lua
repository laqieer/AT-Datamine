-- このluaスクリプトは、MA_01107_11.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos114011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_001)
	Camera006 = SetTemplate("Actor006",160,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_pos(Actor006,{0.5,0,3.3})
change_face(Actor001,"Smile")
change_face(Actor002,"Smile")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor001,"to Greet_one")
PlayActionDirect(Actor002,"to Greet_one")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor001,"Smile")
	on_cutin(2,Actor002,"Smile")

	--★★フレン／ローラ★★:ようこそ<br>ローマの都へ
	Talk(Actor007,"CHRNAME_FREN_LOLA","speech","N","MA_01107_110002")

	close_cutin()
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ローラ★★:アーサー様からお話は伺っています<br>宮殿でルーシャス皇太子殿下がお待ちです
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01107_110004")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:さすが<br>アーサー様は根回しもウマイ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01107_110005")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★フレン★★:あまり期待しない方がいいよ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_110006")

-- ▼直接出力
change_face(Actor003,"Normal")
-- ▲直接出力

	--★★ギネヴィア★★:どういう意味？
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01107_110007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★フレン★★:言葉通りに受け取ってもらって構いません<br>ギネヴィア王妃殿下
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_110009")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)

	--★★ノワール★★:街中に兵士が多い…<br>これはカレドニア対策じゃないのか？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01107_110010")


	--★★ローラ★★:だったら…なんです？
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01107_110011")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Smile")

	--★★トリスタン★★:ログレスと仲良しのローマ大帝国サマなら<br><ruby=カレドニア>敵</ruby>を倒すためにこの兵士を使ってくれるよね？
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_110012")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
change_face(Actor006,"Normal")
-- ▲直接出力

	--★★フレン★★:大陸本国から送られてくる兵士たちはあくまで<br>ロンディニウムを守るためのものらしいよ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_110014")


	--★★フレン★★:ロンディニウムに住むローマ市民のためのもの<br>ただそれだけなんだって
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_110015")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
reserve_eyesync(Actor004,"Close")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ギネヴィア★★:交渉は難航しそうね
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01107_110016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
reserve_eyesync(Actor004,"Auto")
-- ▲直接出力

	--★★フレン★★:忠告はしました、ギネヴィア王妃殿下<br>お覚悟がよければいらしてください
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_110017")


	--★★フレン★★:なお、武器の類の持ち込みはご遠慮ください<br>皇太子殿下への礼儀からはずれますので
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_110018")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor001)
Hide(Actor002)
set_rot(Actor003,{0,125,0})
set_pos(Actor006,{0.7,0,2.8})
set_rot(Actor006,{0,-120,0})
change_face(Actor004,"Normal")
change_face(Actor006,"Normal")
lookoj=create_object("kara")
set_pos_object(lookoj,0.5,0,2)
keep_delay_ik_lookat_object(Actor003,lookoj,"kara",1.0)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★トリスタン★★:面白がって「断る」とか言うよ、きっと<br>ボクらの救援要請なんて
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_110020")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:この戦い乗り切んのに<br>ローマの力ぜってー要るって
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01107_110022")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Smile")

	--★★トリスタン★★:ヴェルナルス先生もとい大将軍は<br>頼もしくて憧れるよねえ
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_110023")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ガウェイン★★:そ、そーだよ、わりーか
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01107_110024")

	change_face(Actor003,"Anger")

	--★★ガウェイン★★:トリスタンこそ乗り気じゃねーのに<br>なんでついて来たんだよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01107_110025")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★トリスタン★★:自分の目で確かめたいしね<br>皇太子殿下のこと…
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_110027")

	change_face(Actor006,"Smile")

	--★★トリスタン★★:それにボクは継承者の監視だからね
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_110029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
change_face(Actor003,"Normal")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★トリスタン★★:キミはさ<br>なににそんなに固執してるんだい？
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_110030")


	--★★トリスタン★★:学園に従って、家族を救って<br>敵を助けて、どっちつかず
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_110031")

	PlayAction(Actor006,"to  Std_Worry")
	change_face(Actor006,"Anger")

	--★★トリスタン★★:敵にも味方にも献身的で<br>ちょっと気持ち悪いったらない
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_110032")

	change_face(Actor006,"Smile")

	--★★トリスタン★★:いつ音を上げるか<br>愉しみなんだ
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_110033")

	open_select_window_tag(Actor005,"Normal","MA_01107_110035","MA_01107_110036")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★ノワール★★:どっちつかずのつもりはない
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01107_110038")

	change_face(Actor005,"Normal")

	--★★ノワール★★:『本当』に辿り着くために<br>俺は自分の信じた道を進んでいるだけだ
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01107_110039")

	change_face(Actor006,"Normal")

	--★★トリスタン★★:気づいてないだけじゃないの？<br>いいように利用されてるってことがさ
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_110040")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★ノワール★★:『本当』に辿り着けるまで<br>音を上げたりしない
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01107_110042")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
change_face(Actor006,"Normal")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:トリスタン<br>こいつは音を上げたりしねえよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01107_110043")

	change_face(Actor003,"Smile")

	--★★ガウェイン★★:キャメリアードでの戦いを<br>近くで見たオレにはわかる
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01107_110044")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★トリスタン★★:いつか聴けるといいな、キミの本音
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_110046")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
