-- このluaスクリプトは、MA_01C111_21.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_03","111013_03_h")
Include("content_adv_advsmall_111013_03","Template111013_03_h")
Include("content_adv_advsmall_111013_01","111013_01_h")
Include("content_adv_advsmall_111013_01","Template111013_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111013_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111013_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_006)
	Camera005 = SetTemplate("Actor005",-175,CharaPos111013_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_007)
	Camera006 = SetTemplate("Actor006",180,CharaPos111013_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111013_03_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_009)
	InitializeTemplateRandomCamera111013_03()
	InitializeTemplate111013_03()
-- ▼直接出力
DontChangeRandomCamera(true)
Ef_Aura_Enemy1 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,false)
local EfPos = get_pos(Actor003)
set_pos(Ef_Aura_Enemy1,EfPos)
Ef_Aura_Enemy2 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave02",false,true)
local EfPos = get_pos(Actor003)
set_pos(Ef_Aura_Enemy2,EfPos)
Ef_Aura_Enemy3 = load_particle("content_effect3d_common_adv","Ef_C_Adv_MagicDefense",false,true)
local EfPos = get_pos(Actor003)
set_pos(Ef_Aura_Enemy3,EfPos)
sword_01 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
sword_02 = set_object("content_weapon_101030001", "weapon_model_101030001", true)
weapon_offset = {0,0,0,0,0,0}
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName111013_01,CameraPos111013_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111013_01,CameraPos111013_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111013_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_01,CameraPos111013_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111013_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_01,CameraPos111013_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111013_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_01,CameraPos111013_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111013_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_01,CameraPos111013_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111013_01_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName111013_01,CameraPos111013_01_009)
	InitializeTemplateRandomCamera111013_01()
	InitializeTemplate111013_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101044","001","101044001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101045","001","101045001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101046","001","101046001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モーロノエー","挨拶")
-- ▲直接出力

	--★★モーロノエー★★:皇太子殿下、お願いがあるのよ
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス","挨拶")
-- ▲直接出力

	--★★ルーシャス★★:なんだ、申してみよ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_210003")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("モーロノエー","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モーロノエー★★:ロンディニウムの住人たちの記憶を<br>いただかせてもらっていいかしら♪
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210004")

-- ▼直接出力
 --PlayPartVoice("ルーシャス","怒り")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ルーシャス★★:なんだと…！？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_210005")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("モーロノエー","肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モーロノエー★★:もうすぐハロウィンでしょう？<br>魔女は力が増えちゃうのよね
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210006")


	--★★モーロノエー★★:そのぶん、お腹が空いちゃって<br>たくさんの人間の記憶を取り込まないと
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210007")


	--★★モーロノエー★★:皇太子殿下と私たちが同盟関係にあるなら
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210008")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Talk")
 --PlayPartVoice("モーロノエー","喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モーロノエー★★:私たちはロンディニウムの人たちを<br>自由にしてもいいわよね？
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス","激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ヴェルナルス★★:いいわけがなかろう！
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01C111_210010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
 --PlayPartVoice("モーロノエー","悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モーロノエー★★:なにを驚くことがあるの？<br>元より行おうとしていたことでしょう
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210011")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス","否定")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ルーシャス★★:手を下すのはあくまで余だ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_210012")


	--★★ルーシャス★★:そなた貴様たちの胃袋に落ちたものを<br>余が覗けなければ意味がない
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_210013")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("モーロノエー","笑い")
-- ▲直接出力

	--★★モーロノエー★★:ハラを割るのは<br>敵が共通しているときだけよ
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス","怒り")
-- ▲直接出力

	--★★ルーシャス★★:裏切るつもりか
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_210016")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
setup_small_camera_start(Camera004)
set_animationcontroller(Actor001,"Chr_020_01_StdController","to Std_Loop")
set_pos(Actor001,{0,1.4,-20.9})
 --PlayPartVoice("グリーテン","笑い")
-- ▲直接出力

	--★★グリーテン★★:魔女は魔女<br>人は人、ブリテンはブリテン、ローマはローマ
	Talk(Actor004,"CHRNAME_SISTERS_3","speech","L","MA_01C111_210017")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
slidemove2(Actor001,{0,1.71,-20.5},1,3)
 --PlayPartVoice("ルーシャス","激怒")
-- ▲直接出力

	--★★ルーシャス★★:もともと信用などしてはいなかったが<br>そなたたちがそのつもりなら――…
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_210018")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0,0.2)
se_play("SE_ADV_MA_01C111_21_Sword")
wait_time(0.2)

set_rot(Actor005,{0,-165,0})
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor005,"to Std_Loop")
PlayActionDirect(Actor006,"to Std_Loop")
set_animationbattlecontroller(Actor001, 1, false)
PlayActionDirect(Actor001,"ToIdle")
on_parent(sword_01,Actor001,"Loc_weapon_constrint_R",weapon_offset)
set_pos(Actor001,{0.5,0,-9.5})
set_rot(Actor001,{0,-15,0})
set_animationbattlecontroller(Actor002, 3, false)
PlayActionDirect(Actor002,"ToIdle")
on_parent(sword_02,Actor002,"Loc_weapon_constrint_R",weapon_offset)
set_pos(Actor002,{-1,0,-9})
set_rot(Actor002,{0,30,0})
on_active(Ef_Aura_Enemy1) 
play_particle(Ef_Aura_Enemy1)
setup_small_camera_start(RndCamera001)
wait_time(0.5)
fadein(1)
on_active(Ef_Aura_Enemy2) 
play_particle(Ef_Aura_Enemy2)
on_active(Ef_Aura_Enemy3) 
play_particle(Ef_Aura_Enemy3)
wait_time(0.2)
on_active(Ef_Aura_Enemy3) 
play_particle(Ef_Aura_Enemy3)
wait_time(1)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera002)
 --PlayPartVoice("ヴェルナルス","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ヴェルナルス★★:なにっ！？
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01C111_210020")

	PlayAction(Actor003,"to  Std_Appl")
-- ▼直接出力
setup_small_camera_start(RndCamera008)
 --PlayPartVoice("モーロノエー","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モーロノエー★★:あらあら、威勢のいいこと
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210021")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モーロノエー★★:私たちが裏切っても<br>斬り捨てればいいとでも考えてらした？
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210022")

	PlayAction(Actor003,"to  Std_Talk")

	--★★モーロノエー★★:教えてあげたでしょ？<br>魔女の力、増幅されてるって
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210023")

-- ▼直接出力
 --PlayPartVoice("モーロノエー","喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モーロノエー★★:計算が違っちゃってごめんなさいねえ
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210024")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("グリートーネア","落胆")
-- ▲直接出力

	--★★グリートーネア★★:もっとも…増幅されていなかったとしても<br>倒されることなんてありませんけど
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01C111_210025")

-- ▼直接出力
setup_small_camera_start(Camera005)
PlayActionDirect(Actor005,"to Std_Loop")
set_animationcontroller(Actor001,"Chr_020_01_StdController","to Std_Loop")
set_animationcontroller(Actor002,"Chr_019_01_StdController","to Std_Loop")
off_parent(sword_01)
off_active(sword_01)
off_parent(sword_02)
off_active(sword_02)
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★グリートーネア★★:<ruby=ゲシュタルト・シフト>ＧＳ</ruby>も済ませていないあなたたちなんかに
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01C111_210026")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
 --PlayPartVoice("ヴェルナルス","激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ヴェルナルス★★:…チィッ！
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01C111_210028")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("グリートン","笑い")
-- ▲直接出力

	--★★グリートン★★:この契約は<br>もともと対等ではなかったのよ
	Talk(Actor006,"CHRNAME_SISTERS_5","speech","L","MA_01C111_210029")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ルーシャス","激怒")
-- ▲直接出力

	--★★ルーシャス★★:言わせておけば…！
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_210030")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("モーロノエー","悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モーロノエー★★:でも、これだと<br>私たちがあまりに横暴よね
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210031")


	--★★モーロノエー★★:評判が悪いと<br>次のクライアントがついてくれなくなっちゃう
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210032")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モーロノエー","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モーロノエー★★:ひとつ条件を出してあげるわ
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210033")

-- ▼直接出力
 --PlayPartVoice("ルーシャス","怒り")
-- ▲直接出力

	--★★ルーシャス★★:条件？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_210034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モーロノエー","挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モーロノエー★★:継承者とそのキラーズをここに呼んで
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210035")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス","悩む")
-- ▲直接出力

	--★★ルーシャス★★:ノワールと…その妹をか？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_210036")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ルーシャス★★:ヤツらを連れてくるだけなら<br>余の手など必要ないのではないか？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C111_210037")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("モーロノエー","悩む")
-- ▲直接出力

	--★★モーロノエー★★:それがねえ…<br>あの学園にはちょっとしたお邪魔虫がいるの
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210039")


	--★★モーロノエー★★:ふたりを連れてきたら<br>ロンディニウムに手は出さないわ
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_210041")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("グリーテン","肯定2")
-- ▲直接出力

	--★★グリーテン★★:できない場合は皇太子殿下も<br>無事ではすまないかもしれませんね
	Talk(Actor004,"CHRNAME_SISTERS_3","speech","L","MA_01C111_210042")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("グリートーネア","笑い")
-- ▲直接出力

	--★★グリートーネア★★:急いだほうがいいわよ
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","L","MA_01C111_210043")

	PlayAction(Actor006,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("グリートン","笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★グリートン★★:さあさあ、急ぎなさいな！
	Talk(Actor006,"CHRNAME_SISTERS_5","speech","L","MA_01C111_210044")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,0.5)
wait_time(0.5)
off_active(Ef_Aura_Enemy1)
stop_particle(Ef_Aura_Enemy1)
Hide(Actor001)
Hide(Actor002)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
Appear(Actor007)
template2()
change_face(Actor007,"Sad")
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to  Std_Surp")
setup_small_camera_start(Camera007)
wait_time(0.5)
fadein(0.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ローラ","悲しみ")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★ローラ★★:そんな…ロンディニウムの人たちが…<br>ルーシャス様が…！
	Talk(Actor007,"CHRNAME_LOLA","speech","L","MA_01C111_210046")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,false)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave02",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_MagicDefense",false,true)
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
set_object_preload("content_weapon_101030001", "weapon_model_101030001", true)
weapon_offset = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101044","001","101044001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101045","001","101045001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101046","001","101046001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_03)
	system.PreLoadRequest(CameraAssetBundleName111013_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
