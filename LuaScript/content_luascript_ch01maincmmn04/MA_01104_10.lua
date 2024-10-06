-- このluaスクリプトは、MA_01104_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_019,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_019)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
load_image("102010020_StillImage", "content_still_10201002_image", "102010020_StillImage")
load_image("MA011041002", "content_still_10101001_image", "101010010_StillImage")
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:退学、願いたいところだが
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:なにを、いきなり…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_100003")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:そ、そんな…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_100004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:学園内の平穏を守るのが私の仕事<br>王はさておき、私は貴公を認めたくはない
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100005")

	change_face(Actor003,"Smile")

	--★★アーサー★★:俺をさておかれては困るなぁ義兄さん
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01104_100006")


	--★★ケイ★★:王の仕事が多忙だからと、学内のことは<br>私に任せきりの貴公が言うことかね
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100007")

	PlayAction(Actor003,"to Sit01_Talk")

	--★★アーサー★★:推薦入学を妬む者がいるならば<br>入学試験をパスすれば良いわけだな？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01104_100008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ケイ★★:今は試験など満足に出来まい？<br>あの場所はもうカレドニアの支配地域だ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:入学試験？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_100011")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★アーサー★★:バルバロイと戦う素養の有無を<br>見定めるための儀式だ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01104_100012")

-- ▼直接出力
DontChangeRandomCamera(true)
CloseTalkWindow()
show_image("102010020_StillImage", 0.0, 0.0, 0.3, false, false)
wait_time(0.6)
-- ▲直接出力

	--★★ケイ★★:隣国キャメリアードの果てに突き立つ剣<br>それに触れ、共鳴が起こるか否か
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100013")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.6)
wait_time(1.2)
show_image("MA011041002", 0.0, 0.0, 0.0, true, false)
fadein(0.6)
wait_time(0.6)
-- ▲直接出力

	--★★アーサー★★:その剣を我らは『カリバーン』と呼んでいる<br>ブリテン史上、誰ひとり抜いたことのない剣だ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01104_100014")

-- ▼直接出力
CloseTalkWindow()
hide_image(1.0)
wait_time(1.6)
-- ▲直接出力

	--★★アーサー★★:<dot>武器</dot>に類する素質があるか否かが選定される<br>あればその者の力の一部が呼び起こされる
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01104_100015")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★ノワール★★:カリバーンの、共鳴…<br>それが起こらない場合は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_100017")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:戦えるほどの素質がないとされる<br>戦力外通告というやつだな！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01104_100018")


	--★★ケイ★★:…もし仮に共鳴が起こったとして<br>キラーズ無き者に円卓は任せられぬよ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100019")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01104_20_DoorOpen")
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor005,Camera005,EntryData110051_02_17,CameraAssetBundleName110051_02,CameraPos110051_02_117)
-- ▲直接出力

	--★★ランスロット★★:もし仮に<br>剣を抜くことができたなら？
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01104_100021")


	--★★ケイ★★:………ありえんことだ<br>それではまるで－－
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:儀式を経ないままでバルバロイは倒せない<br>あれは次元を異にする怪物だからな
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01104_100023")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ランスロット★★:だがノワールはその行程を踏まず<br>バルバロイを倒せたと聞く、なぜだ？
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01104_100024")

	change_face(Actor003,"Normal")

	--★★アーサー★★:…
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01104_100025")

	change_face(Actor004,"Sad")

	--★★ケイ★★:…カリバーンを抜く者が現れるとなれば<br>ランスロット、それは－－…いや、しかし
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100026")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:まあ不公平は良くないな！<br>全生徒にやってもらってることだし！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01104_100027")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Anger")

	--★★ケイ★★:言っただろう、かの地はもはや<br>カレドニアに侵略しつくされ－－
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100028")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01104_20_DoorOpen")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
EntryWalk_2P(Actor006,Camera006,EntryData110051_02_19,CameraAssetBundleName110051_02,CameraPos110051_02_119,Actor007,CharaPos110051_02_020,CharaPos110051_02_120)
-- ▲直接出力

	--★★ギネヴィア★★:お目付け役が要るわね
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","MA_01104_100030")

	change_face(Actor004,"Normal")

	--★★ケイ★★:…何故このような者に目をかけるのです？<br>殿下はただ座していればいいものを
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100031")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力

	--★★ギネヴィア★★:わたしのためでもあるの
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","MA_01104_100032")


	--★★ケイ★★:…テコでも動きませんか
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100033")

	PlayAction(Actor006,"to  Std_Angry")

	--★★ギネヴィア★★:止められたって出てってやるわ
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","MA_01104_100034")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
lookat_weight(Actor002,1.0,0.5,0.5,0.5)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:兄さん、私も－－…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_100035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
lookat_delay_weight_reset(Actor002,0.6)
-- ▲直接出力

	--★★ケイ★★:…ならば貴公は留守番としよう<br>ディナタン
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100036")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:どうして…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_100037")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:人質だ。出先で彼が裏切り、殿下を殺す…<br>といった事態も考えられる
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100038")

	open_select_window_tag(Actor001,"Normal","MA_01104_100039","MA_01104_100040","MA_01104_100041")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロットがしてくれた推薦を<br>無駄にしたくない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_100043")

	change_face(Actor001,"Normal")

	--★★ノワール★★:真意はわからないけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_100044")

	change_face(Actor005,"Normal")

	--★★ランスロット★★:…期待させてくれ
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01104_100045")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:雇い主がお目付け役を<br>買って出てくれたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_100047")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:迷惑をかけるつもりはない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_100048")

	PlayAction(Actor006,"to Greet_one")
	change_face(Actor006,"Laugh")

	--★★ギネヴィア★★:お気遣いどーも
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","MA_01104_100049")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キラーズだ儀式だと<br>わからないことだらけだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_100051")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:すぐに戻ってくる<br>待っていてくれディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_100052")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:…けが、しないでね。兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_100053")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:騎士たちが遠征から帰還次第<br>キャメリアードを取り戻す算段であったが…
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100055")


	--★★アーサー★★:ははあ、さては義兄さん<br>危ないからヤメておけって言いたいわけだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01104_100056")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:…良かろう、バルバロイの制圧地域を抜けて<br>無事儀式を終えて見せよ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100057")


	--★★ケイ★★:仮に共鳴なく、素質なくば<br>帰る場所も失うと知れ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_100058")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102010020_StillImage", "content_still_10201002_image", "102010020_StillImage")
load_image_preload("MA011041002", "content_still_10101001_image", "101010010_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
