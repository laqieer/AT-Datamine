-- このluaスクリプトは、CO_101065_0703.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_02","112041_02_h")
Include("content_adv_advsmall_112041_02","Template112041_02_h")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112041_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_006)
	InitializeTemplateRandomCamera112041_02()
	InitializeTemplate112041_02()
-- ▼直接出力
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor003, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_005)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to Sit01_Loop")
-- ▼直接出力
PlayPartVoice("貴族_男1", "肯定2")
-- ▲直接出力

	--★★貴族（男）②★★:君のやっていることは素晴らしいことだと思うしかし、相手はひとりじゃない
	Talk(Actor004,"NPCNAME_0177","speech","N","CO_101065_07030002")


	--★★貴族（男）②★★:危険すぎるエージェントの仕事の域を超えてしまっている
	Talk(Actor004,"NPCNAME_0177","speech","N","CO_101065_07030003")

-- ▼直接出力
PlayPartVoice("貴族_男1", "肯定3")
-- ▲直接出力

	--★★貴族（男）②★★:万が一の事態が起きて君を失うことになるのはウチとしても相当な痛手になる
	Talk(Actor004,"NPCNAME_0177","speech","N","CO_101065_07030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to Sit01_Loop")
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:彼らは宝よ彼らがこれから新しい歴史を紡いでいくの
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030006")


	--★★キッス★★:彼らを失うことのほうが世界にとっての痛手だわ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030007")

-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力

	--★★キッス★★:アタシは未来のために彼らのお手伝いをするそれだけよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030009")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera004)
end
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("貴族_男1", "悩む")
-- ▲直接出力

	--★★貴族（男）②★★:なにを言っても無駄なようだ私はこれで失礼するよ
	Talk(Actor004,"NPCNAME_0177","speech","N","CO_101065_07030011")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor004)
template2()
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Surprise")

	--★★キッス★★:あら、ラビットちゃんもう10分経っちゃってた？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030013")

	change_face(Actor002,"Normal")

	--★★キッス★★:恥ずかしいところ見せちゃったわねぇ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:今のは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030015")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力

	--★★キッス★★:ん～…ちょっと困ったお客さん？悪い人ではないんだけどね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030016")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ごめん、聞いちゃってでも、今の話って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030017")

-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:あー、やっぱり気になっちゃう？そうよねぇ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★キッス★★:ラビットちゃんは、今この世界でもっとも需要の高い商材がなにか知ってる？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030021")


	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030023")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★キッス★★:人間よ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キッス★★:お金や権力を持っている者たちは手足のように使える人間を欲しがるの
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030026")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力

	--★★キッス★★:なかでも子供は高値で取引されているわ言うことをきかせやすいから
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030027")


	--★★キッス★★:でもね、そのせいで子供がさらわれる事件が頻発しているの
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030028")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:年端もいかぬ子供たちが召し使いとして酷い扱いを受けたり
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030030")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:戦場に駆り出される光景を何度も見てきたことがある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030031")

	change_face(Actor001,"Normal")

	--★★ノワール★★:助けられるなら、助けてやりたいよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:そうよだからアタシもアタシにできることをする
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:さっきの…「お手伝い」か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030034")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:そこまで聞かれてたの？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キッス★★:あんまりアタシのキャラじゃないと思った？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101065_07030038","CO_101065_07030039")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:正直言うと…ちょっと思った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030041")

-- ▼直接出力
PlayPartVoice("キッス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:もう！ラビットちゃんってば失礼ねえ！
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030042")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★キッス★★:でも、ときおり突き放した態度を取られるとクラッと来ちゃうこともあるのよね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030043")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:思ってないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030045")

-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:本当に？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030046")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:本当さ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030047")

-- ▼直接出力
PlayPartVoice("キッス", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:紳士的なフォローのしかたを知ってるみたいねえ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030048")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★キッス★★:これはアタシが予想した以上に素敵なオトナになってくれそう♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030049")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたが扱う依頼のなかには
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030051")


	--★★ノワール★★:そういう子供たちを助けられるようなものもあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030052")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:ええ、もちろん
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キッス★★:アタシと同じように彼らの未来を憂いている人は大勢いるもの
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030054")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:じゃあ、もしそういう依頼があったら俺にも紹介してくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030055")


	--★★ノワール★★:できるかぎり力になりたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030056")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★キッス★★:本当に見込みのあるラビットちゃんね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030058")

	change_face(Actor002,"Smile")

	--★★キッス★★:いいわ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030059")

	change_face(Actor002,"Normal")

	--★★キッス★★:なにかあったら真っ先に紹介してあげるからそのときはよろしくね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07030060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ任せてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07030061")

-- ▼直接出力
local trustParam = set_communication_rankup("キッス_コミュランク", "キッス_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_02)
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
