-- このluaスクリプトは、MA_01B900_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111061_03","111061_03_h")
Include("content_adv_advsmall_111061_03","Template111061_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111061_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName111061_03,CameraPos111061_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111061_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName111061_03,CameraPos111061_03_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111061_03_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111061_03,CameraPos111061_03_012)
	InitializeTemplateRandomCamera111061_03()
	InitializeTemplate111061_03()
-- ▼直接出力
set_animationbattlecontroller(Actor001, 2, true)
FigMbo = set_object("content_weapon_107010001", "weapon_model_107010001", true)
weapon_offset = {0,0,0,0,0,0}
on_parent(FigMbo,Actor001, "Loc_weapon_constrint_R",weapon_offset)
PlayActionDirect(Actor001,"ToAbnormal")
SkipDefaultMotion(Actor001)
Ef_Aura_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", true, true)
local ARTHUR_EfPos = get_pos(Actor003)
set_pos(Ef_Aura_Enemy, ARTHUR_EfPos)
change_face(Actor003,"Sad")
force_eyesync(Actor003,"Close")
reserve_eyesync(Actor003,"Close")
set_enable_auto_lookat_all(false)
set_active_facial_control(Actor001,true)
-- ▲直接出力
-- ▼直接出力
load_image("101020230", "content_still_10102023_image", "101020230_StillImage")
load_image("101020240", "content_still_10102024_image", "101020240_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111061)
	Actor001 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101041","002","101041002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("モルガンB", "肯定")
-- ▲直接出力

	--★★モルガン★★:看取る覚悟なんて御免なの
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180002")

	change_face(Actor001,"Pain")

	--★★マーリン★★:モル、ガン…！！
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B900_180003")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★モルガン★★:あともどりできる道でもない
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180004")


	--★★マーリン★★:モルガン…あなたを止めなかったのは私の落ち度<br>ですがあなたは揺らいでいた…！
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B900_180005")


	--★★マーリン★★:彼は人としての生死を望んでいた！<br>あなたは彼の意志を捻じ曲げるべきか迷っていた
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B900_180006")

-- ▼直接出力
 --PlayPartVoice("マーリン", "苦しみ")
-- ▲直接出力

	--★★マーリン★★:ですから私は、あなたとともに<br>アーサーを──
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B900_180007")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("モルガンB", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:ペレス王の判断には一定の評価をしているの、私<br>アーサーを殺そうという判断以外はね？
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルガン★★:だから姉妹たちもその身を投じ、力を貸した
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180010")


	--★★モルガン★★:…「救済者を救うのは誰か」
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180011")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力

	--★★モルガン★★:彼が指した救済者とは<br>継承者やそのキラーズのことだけれど
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180012")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("モルガンB", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:私にとっての救済者はアーサーよ
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180013")

-- ▼直接出力
 --PlayPartVoice("マーリン", "苦しみ")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Pain")

	--★★マーリン★★:私にとっても、そうです…！<br>モルガン、私たちの心は、同じであったはず…！！
	Talk(Actor001,"CHRNAME_MERLIN","speech","N","MA_01B900_180014")


	--★★マーリン★★:あなたと私──<br><dot>同じ妖精</dot>として…！
	Talk(Actor001,"CHRNAME_MERLIN","speech","N","MA_01B900_180015")

	close_cutin()
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルガン★★:妖精の里はバルバロイに喰い散らかされ<br>ニニアンは人と交わり穢れ…言わば諸悪の根源に
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180017")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★モルガン★★:私は安息の地を探してさまよった<br>自らの出自と運命を呪いながら
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180019")


	--★★モルガン★★:辿り着いたのは<br>アーサーの母イグレーヌのもと
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180020")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガンB", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:そこでやっと見つけた生きる希望<br>アーサー
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180021")


	--★★モルガン★★:私も…乳母としてではあったけれど<br>家族を持てるのだと感じたわ
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180022")


	--★★モルガン★★:幸せとぬくもりを<br>得ることができるのだと
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180023")

-- ▼直接出力
 --PlayPartVoice("モルガンB", "笑い")
-- ▲直接出力

	--★★モルガン★★:無条件に愛してくれる誰かがいるというのは<br>…こんなにも、こんなにも安らぐものなのだと
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マーリン", "激怒")
-- ▲直接出力

	--★★マーリン★★:彼が与えてくれる愛に<br>応えようとは思わないのですか…！？
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B900_180025")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★モルガン★★:貴方と私は違う
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180026")


	--★★モルガン★★:貴方はひとりの女としてアーサーと出会った<br>私は家族として彼と生きて来た
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180027")


	--★★モルガン★★:貴方は庇護される立場としてアーサーに愛された<br>私は庇護する立場として彼を愛し彼に愛された
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180028")


	--★★モルガン★★:私はその愛に応えるために穢れたの<br>これで彼と同じになれた
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180029")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガンB", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:私──彼と、同じ生きかたをしたいの
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180031")

-- ▼直接出力
 --PlayPartVoice("マーリン", "否定")
-- ▲直接出力

	--★★マーリン★★:ちがう…！彼は死しても学園を愛し続けんとした<br>笑顔溢れる平和を守るべく死を覚悟した…！！
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B900_180032")

-- ▼直接出力
 --PlayPartVoice("モルガンB", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルガン★★:本人に憎まれようと…<br>世界に疎まれようと…
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180033")


	--★★モルガン★★:それでも子の生き延びる道を望むのが<br>親というもの、家族というもの、違うかしら？
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180034")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor002,0.685, 0, 6.953,1.8)
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガンB", "挨拶")
-- ▲直接出力

	--★★モルガン★★:ねえ教えて、マーリン？
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180036")


	--★★モルガン★★:愛する者を護る道<br>正しいのはどちらの歩みか
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180037")


	--★★モルガン★★:貴方のように<br>無慈悲な死を確定させるべきか
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180038")


	--★★モルガン★★:私のように<br>永遠の楽園を与えるべきか
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180039")

-- ▼直接出力
 --PlayPartVoice("マーリン", "苦しみ")
-- ▲直接出力

	--★★マーリン★★:………アーサーの、選択は…！
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B900_180040")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
show_image("101020230",0,0,0,true,false)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002, {0.027, 0, 7.408 })
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガンB", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:答えは明白よね？
	Talk(Actor002,"CHRNAME_MORGAN2","simple","N","MA_01B900_180042")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
se_play("SE_ADV_MA_01B900_18_Body_Suction")
wait_time(6.0)
hide_image()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,170,0.6)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルガン★★:己のことなど最もわからないものよ<br>虚栄、義務、責任…王には抱えるものが多すぎる
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180044")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
 --set_pos(Actor002, {1.699, 0, 0.118})
-- ▲直接出力
-- ▼直接出力
 --turn(Actor002,0,200,0,0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガンB", "笑い")
-- ▲直接出力

	--★★モルガン★★:でも安心して…もう悩みなど捨てて<br>だってここは泥濘の底…
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180045")


	--★★モルガン★★:妖精を<ruby=うしな>喪</ruby>ったログレスの者どもは<br>誰も足を踏み入れられない…私たちだけの愛の園
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180046")

-- ▼直接出力
 --PlayPartVoice("モルガンB", "喜び")
-- ▲直接出力

	--★★モルガン★★:ここで貴方がバルバロイの王となるまで<br>じっくりと育てるだけで世界は終わる
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180048")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor002,-0.042,0,4.216,1.8)
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:いきて。アーサー
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180050")


	--★★モルガン★★:不滅の道を往きて<br>いずれ拓く楽園『アヴァロン』の奥底で
	Talk(Actor002,"CHRNAME_MORGAN2","speech","R","MA_01B900_180051")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
show_image("101020240",0,0,0,true,false)
fadein(FADE_TIME)
wait_time(FADE_TIME + 0.2)
-- ▲直接出力

	--★★モルガン★★:永劫<br>幸せに穢れて生きて
	Talk(Actor002,"CHRNAME_MORGAN2","simple","N","MA_01B900_180053")

-- ▼直接出力
 --PlayPartVoice("モルガンB", "笑い")
-- ▲直接出力

	--★★モルガン★★:私が、産みなおしてあげる
	Talk(Actor002,"CHRNAME_MORGAN2","simple","N","MA_01B900_180054")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
set_object_preload("content_weapon_107010001", "weapon_model_107010001", true)
weapon_offset = {0,0,0,0,0,0}
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", true, true)
load_image_preload("101020230", "content_still_10102023_image", "101020230_StillImage")
load_image_preload("101020240", "content_still_10102024_image", "101020240_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(111061)
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101041","002","101041002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111061_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
