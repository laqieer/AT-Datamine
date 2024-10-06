-- このluaスクリプトは、MA_01B112_35.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_11","111016_11_h")
Include("content_adv_advsmall_111016_11","Template111016_11_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_11_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111016_11,CameraPos111016_11_012)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_11_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName111016_11,CameraPos111016_11_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111016_11_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_018_01_StdController","to Std_Loop",CameraAssetBundleName111016_11,CameraPos111016_11_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111016_11_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111016_11,CameraPos111016_11_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111016_11_016,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName111016_11,CameraPos111016_11_016)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111016_11_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_015_01_StdController","to Std_Loop",CameraAssetBundleName111016_11,CameraPos111016_11_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111016_11_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleName111016_11,CameraPos111016_11_005)
	Camera008 = SetTemplate("Actor008",nil,CharaPos111016_11_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_017_01_StdController","to Std_Loop",CameraAssetBundleName111016_11,CameraPos111016_11_006)
	Camera009 = SetTemplate("Actor009",nil,CharaPos111016_11_014,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName111016_11,CameraPos111016_11_014)
	Camera010 = SetTemplate("Actor010",nil,CharaPos111016_11_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName111016_11,CameraPos111016_11_015)
	InitializeTemplateRandomCamera111016_11()
	InitializeTemplate111016_11()
-- ▼直接出力
Ef_Aura_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
Ef_MagicChanting = load_particle("content_effect3d_common_adv", "Ef_C_Adv_MagicChanting", false, true)
Ef_MagicBind = load_particle("content_effect3d_common_adv", "Ef_C_Adv_MagicBind", false, true)
local PEREZ_EfPos = get_pos(Actor003)
local SISTERS_EfPos = get_pos(Actor004)
set_pos(Ef_Aura_Enemy, PEREZ_EfPos)
set_pos(Ef_MagicChanting, PEREZ_EfPos)
set_pos(Ef_MagicBind, SISTERS_EfPos)
set_enable_auto_lookat_all(false)
load_sound("BGM_Battle_AfterLancelot_General1_Start")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101056","002","101056002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101053","002","101053002","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101054","002","101054002","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101055","002","101055002","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101025","002","101025002","content_animationpack__common","FacialPack","Actor010")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor010,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★アーサー★★:座すべき者はすべてに平等<br>それが円卓を囲む騎士たちの精神だ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B112_350002")

	PlayAction(Actor004,"to  Std_Talk")

	--★★モーロノエー★★:だけどその平等の学生生活を守るために<br>継承者のキラーズを犠牲にしていいのかしら？
	Talk(Actor004,"CHRNAME_SISTERS_1","speech","R","MA_01B112_350004")


	--★★モーロノエー★★:誰かがひとり孤独に震えているなか<br>笑って過ごせるのかしら？
	Talk(Actor004,"CHRNAME_SISTERS_1","speech","R","MA_01B112_350006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
	change_face(Actor004,"Smile")

	--★★モーロノエー★★:ペレス陛下はそれが許せない<br>恩義ある者の遺児を救わねば死に切れない♪
	Talk(Actor004,"CHRNAME_SISTERS_1","speech","R","MA_01B112_350007")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ペレス★★:家族が皆バルバロイと化すのなら<br>バルバロイとして生きる道を拓かねばなるまい
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350008")


	--★★ペレス★★:ランスロット卿には<br>出来うるかぎり長らくの生を
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:銀卓騎士には<br>バルバロイとして生きる世界を
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350010")

	change_face(Actor004,"Normal")

	--★★モーロノエー★★:そして継承者はそのなかで<br>人として生きるのは寂しいであろうから…
	Talk(Actor004,"CHRNAME_SISTERS_1","speech","R","MA_01B112_350012")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★モーロノエー★★:バルバロイと同化させ<br>バルバロイを継承する者として祀り上げる♪
	Talk(Actor004,"CHRNAME_SISTERS_1","speech","R","MA_01B112_350013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Angry")
	change_face(Actor005,"Anger")

	--★★フィエナ★★:そのために聖杯を穢して<br>ノワールを侵そうとしていたんだ…！？
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_350014")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ペレス★★:バルバロイに喰われ<br>存在を消し去られるよりは遥かに良かろう
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350015")

	change_face(Actor001,"Sad")

	--★★アーサー★★:あともどり出来ぬバルバロイの道を<br>歩む覚悟の末の行いということだな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B112_350016")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★ペレス★★:笑うがいい。人としての誇りはないのかと<br>他者の道を無理強いするなど馬鹿げていると
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350017")

	PlayAction(Actor001,"to  Std_No")

	--★★アーサー★★:笑わないさ、ペレス王
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B112_350018")


	--★★ペレス★★:父なる彼や妖精のためと口では言いつつ<br>平和とは程遠い行いであると
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350019")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★アーサー★★:ノワールの枷、ランスの孤独<br>すべては支払わなければならない平和の代償だ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B112_350020")


	--★★アーサー★★:その犠牲を…俺は強いる<br>受け入れるか否かは彼らの選択だが
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B112_350021")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★アーサー★★:だからこそ俺は<br>この穢れた血を流し切る覚悟だ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B112_350022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:ペレス王、貴方と同じく
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B112_350023")


	--★★ペレス★★:アーサー王…
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350025")

	change_face(Actor001,"Serious")

	--★★アーサー★★:そして俺が願うは<br>王など要らぬ平和だ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B112_350026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:………成程
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350027")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★アーサー★★:ペレス王、貴方の願いは<br>近い将来に叶うさ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B112_350028")


	--★★ペレス★★:…ならばつける決着は
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350030")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Serious")

	--★★アーサー★★:最強騎士らの道を<br>銀卓と円卓どちらが護るかのみだ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B112_350031")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★モーロノエー★★:安心して♪
	Talk(Actor004,"CHRNAME_SISTERS_1","speech","R","MA_01B112_350033")

	PlayAction(Actor004,"to  Std_Joy")

	--★★モーロノエー★★:共倒れになったところを<br>私がまとめて喰らってあげる
	Talk(Actor004,"CHRNAME_SISTERS_1","speech","R","MA_01B112_350034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
on_active(Ef_MagicChanting) 
-- ▲直接出力
-- ▼直接出力
play_particle(Ef_MagicChanting)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat( Actor003,Actor004, 0.3)
wait_time(0.3)
PlayActionDirect(Actor003,"to  Std_No")
-- ▲直接出力

	--★★ペレス★★:そうは…いかぬな
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350035")

-- ▼直接出力
on_active(Ef_MagicBind) 
-- ▲直接出力
-- ▼直接出力
play_particle(Ef_MagicBind)
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor004)
DontChangeRandomCamera(true)
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★モーロノエー★★:………え
	Talk(Actor004,"CHRNAME_SISTERS_1","speech","R","MA_01B112_350036")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
SkipDefaultMotion(Actor004)
set_battlecontroller(Actor004,"fig_mbo","AC_TL_Fig_Mbo_Idle_Run_F","ToAbnormal")
turn_chara(Actor004,20,0)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★モーロノエー★★:…ッ！？<br>なによ、これ…？
	Talk(Actor004,"CHRNAME_SISTERS_1","speech","R","MA_01B112_350038")


	--★★ペレス★★:銀卓騎士と儂が倒れれば<br>魔女もコルベニック城のバルバロイも終わりだ
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350039")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:お爺様…！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_350040")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:なんのために儂が<br>ロンギヌスに己を貫かせたと思うておる？
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350041")


	--★★ペレス★★:命からがらで魔女の侵蝕を受け入れることで<br>根深くバルバロイと繋がることが出来た
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350042")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★モーロノエー★★:だ、だからっ、なんだって言うのよ…っ！？<br>貴方は私の言うとおりに動いていればいいのよ！
	Talk(Actor004,"CHRNAME_SISTERS_1","speech","R","MA_01B112_350043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ペレス★★:魔女が望もうと儂との分離は不可能<br>姉妹たちの助けはもうないぞ、モーロノエー
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350044")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor004)
lookat_delay_weight(Actor004,1,0.03,0.6,0,0.5)
keep_ik_lookat(Actor004,Actor003,"J_Head")
-- ▲直接出力

	--★★モーロノエー★★:そ、んな…？<br>最初からコレが狙いで…！？
	Talk(Actor004,"CHRNAME_SISTERS_1","speech","R","MA_01B112_350045")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_MagicChanting)
-- ▲直接出力
-- ▼直接出力
stop_particle(Ef_MagicChanting)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_MagicBind)
-- ▲直接出力
-- ▼直接出力
stop_particle(Ef_MagicBind)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_Aura_Enemy) 
-- ▲直接出力
-- ▼直接出力
play_particle(Ef_Aura_Enemy)
wait_time(TIME_ELAPSED)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera011)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
turn_lookat( Actor003,Actor001, 0)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ペレス★★:主導権は今や、このペレスにある
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350046")

	PlayAction(Actor009,"to  Std_Surp")
	change_face(Actor009,"Surprise")

	--★★ヴォールス★★:魔女を、取り込んだ…！？
	Talk(Actor009,"CHRNAME_BORS","speech","L","MA_01B112_350048")

	play_head_motion(Actor010, "Nod", 0.3, 1.0, false)
	change_face(Actor010,"Anger")

	--★★クレア★★:成程…今ペレスを討つことが出来れば<br>魔女姉妹もろともというわけね
	Talk(Actor010,"CHRNAME_CLARE2","speech","L","MA_01B112_350049")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:そうとも<br>雌雄を決しよう
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350050")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:…お爺様の目指す世界が正しいのか否か<br>ガラハッドにはわかりません
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_350052")


	--★★ペレス★★:………誰もわかるものか
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350053")

	PlayAction(Actor002,"to  Std_No")

	--★★ガラハッド★★:お爺様の望む僕の姿など<br>ずっとずっとわかりませんでした
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_350054")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ペレス★★:ガラハッド…そなたには<br>そなたになど、なにひとつ望んではおらぬ…！
	Talk(Actor003,"CHRNAME_PEREZ","speech","R","MA_01B112_350055")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:だけどランスロットを追い<br>ノワールと競い、学園で知った！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_350056")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
bgm_play("BGM_Battle_AfterLancelot_General1_Start")
-- ▲直接出力

	--★★ガラハッド★★:僕は多くを学びたい！<br>心のままに、友や仲間と生きていきたい！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_350057")

-- ▼直接出力
bgm_play("BGM_To_Main")
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ガラハッド★★:ガラハッドになろうとするのではなく…！<br>誰かに言われた道を行くのでもなく！！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_350059")

	PlayAction(Actor002,"to  Std_Angry")

	--★★ガラハッド★★:僕がガラハッドとして<br>生きたい道を！！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_350061")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_MagicChanting", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_MagicBind", false, true)
preload_sound("BGM_Battle_AfterLancelot_General1_Start")
	InitializeLoad_Preload()
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101056","002","101056002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101053","002","101053002","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101054","002","101054002","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101055","002","101055002","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101025","002","101025002","content_animationpack__common","FacialPack","Actor010")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor010,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_11)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
